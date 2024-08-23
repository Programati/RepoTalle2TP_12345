using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Practico5
{
    public partial class Inicio : Form
    {
        private int n = 0;
        string imagePathCelda = null;
        string destinationFilePath = null;
        //Obtener la ruta de la carpeta donde se encuentra el ejecutable
        string ejecutablePath = Application.StartupPath;

        public Inicio()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrEmpty(txtSaldo.Text) || string.IsNullOrEmpty(txtFoto.Text))
            {
                MessageBox.Show("Debe completar todos los campos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Adicionamos un nuevo renglon
                int n = dtgvCliente.Rows.Add();
                TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
                
                //Colocamos la información en el renglon creado
                dtgvCliente.Rows[n].Cells[0].Value = textInfo.ToTitleCase(txtApellido.Text.ToLower());
                dtgvCliente.Rows[n].Cells[1].Value = textInfo.ToTitleCase(txtNombre.Text.ToLower());
                dtgvCliente.Rows[n].Cells[2].Value = dateTimePicker1.Text;

                if(rdbHombre.Checked)dtgvCliente.Rows[n].Cells[3].Value = "Hombre";
                else dtgvCliente.Rows[n].Cells[3].Value = "Mujer";

                dtgvCliente.Rows[n].Cells[4].Value = "Eliminar";

                if (Decimal.Parse(txtSaldo.Text) < 50)dtgvCliente.Rows[n].DefaultCellStyle.BackColor = Color.Red;
                dtgvCliente.Rows[n].Cells[5].Value = Decimal.Parse(txtSaldo.Text);
                                    
                try
                {
                    // Definir la ruta de la carpeta "Fotos"
                    string fotosPath = Path.Combine(ejecutablePath, "Fotos");

                    // Verificar si la carpeta "Fotos" existe, si no, crearla
                    if (!Directory.Exists(fotosPath))
                    {
                        Directory.CreateDirectory(fotosPath);
                    }

                    // Obtener la ruta del archivo seleccionado desde el TextBox `txtfoto`
                    string sourceFilePath = txtFoto.Text;

                    // Obtener el nombre del archivo seleccionado
                    string fileName = Path.GetFileName(sourceFilePath);

                    // Definir la ruta completa de destino donde se copiará la imagen
                    destinationFilePath = Path.Combine(fotosPath, txtApellido.Text+txtNombre.Text+n+fileName);

                    // Copiar el archivo a la carpeta "Fotos"
                    File.Copy(sourceFilePath, destinationFilePath, true);

                    // Informar al usuario que la imagen se guardó con éxito
                    MessageBox.Show("La imagen se ha guardado correctamente en la carpeta 'Fotos'.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Manejar cualquier error que ocurra durante el proceso
                    MessageBox.Show("Ocurrió un error al guardar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Image imagen = Image.FromFile(destinationFilePath);
                dtgvCliente.Rows[n].Cells[6].Value = imagen;

                //Ponemos la ruta en la ultima celda
                dtgvCliente.Rows[n].Cells[7].Value = destinationFilePath;
                //string imagePath = pictureBox1.ImageLocation;

                limpiarCampos();
                destinationFilePath = null;
            }

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',') || (e.KeyChar == ',' && txtSaldo.Text.Contains(",")))
            {
                e.Handled = true;
            }
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            // Crear y configurar el OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog.Title = "Seleccionar una imagen";

            // Mostrar el diálogo y comprobar si se seleccionó un archivo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Cargar la imagen seleccionada en el PictureBox
                string rutaImagen = openFileDialog.FileName;
                pictureBox1.Image = Image.FromFile(rutaImagen);
                // Asignar la ruta al TextBox txtfoto
                txtFoto.Text = rutaImagen;
            }
        }


        private void limpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            dateTimePicker1.Value = DateTime.Now;
            rdbHombre.Checked = true;
            txtSaldo.Clear();
            txtFoto.Clear();
            pictureBox1.Image = Practico5.Properties.Resources.usuario;
        }

        private void dtgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;

            if (n != -1)
            {
                string dato = (string)dtgvCliente.Rows[n].Cells[4].Value;
                string cliente = (string)dtgvCliente.Rows[n].Cells[0].Value + " " + (string)dtgvCliente.Rows[n].Cells[1].Value;
                if (!string.IsNullOrEmpty(dato) && e.ColumnIndex == 4)
                {
                    DialogResult ask = MessageBox.Show("Está a punto de eliminar al Cliente: " + cliente, "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (ask == DialogResult.Yes)
                    {
                        dtgvCliente.Rows[n].Cells[6].Value = null;
                        dtgvCliente.Rows[n].Cells[6].Dispose();


                        // Definir la ruta de la carpeta "Fotos"
                        string fotosPath = Path.Combine(ejecutablePath, "Fotos");

                        // Obtener el nombre del archivo seleccionado
                        string fileName = Path.GetFileName(dtgvCliente.Rows[n].Cells[7].Value.ToString());
                        
                        // Definir la ruta completa del archivo en la carpeta "Fotos"
                        string filePath = Path.Combine(fotosPath, fileName);
                        
                        // Verificar si el archivo existe
                        // Liberar el archivo si está cargado en un PictureBox
                        if (pictureBox1.Image != null)
                            {
                                pictureBox1.Image.Dispose();
                                pictureBox1.Image = null;
                            }
                            
                        MessageBox.Show("El Cliente: " + cliente + " se eliminó correctamente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dtgvCliente.Rows.RemoveAt(n);
                        limpiarCampos();
                        if (File.Exists(filePath))
                        {                            
                            // Eliminar el archivo
                            //File.Delete(filePath);
                        }
                        else
                        {
                            // Informar al usuario que el archivo no existe
                            MessageBox.Show("La imagen no se encontró en la carpeta 'Fotos'.", "Archivo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                     
                    }

                }
                if (!string.IsNullOrEmpty(dato) && e.ColumnIndex != 4)
                {
                    txtApellido.Text = dtgvCliente.Rows[n].Cells[0].Value.ToString();
                    txtNombre.Text = dtgvCliente.Rows[n].Cells[1].Value.ToString();
                    dateTimePicker1.Value = Convert.ToDateTime(dtgvCliente.Rows[n].Cells[2].Value.ToString());
                    if (dtgvCliente.Rows[n].Cells[3].Value.ToString() == "Hombre") rdbHombre.Checked = true;
                    else rdbMujer.Checked = true;
                    txtSaldo.Text = dtgvCliente.Rows[n].Cells[5].Value.ToString();
                    pictureBox1.Image = Image.FromFile(dtgvCliente.Rows[n].Cells[7].Value.ToString());
                    txtFoto.Text = dtgvCliente.Rows[n].Cells[7].Value.ToString();
                }
            }
            // Eliminar el archivo
            //File.Delete(imagePathCelda);
        }
    }
}
