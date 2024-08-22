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

namespace Practico5
{
    public partial class Inicio : Form
    {
        private int n = 0;
        string imagePathCelda = null;
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
                string nombre = txtApellido.Text.ToUpper();

                TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
                
                //Colocamos la información en el renglon creado
                dtgvCliente.Rows[n].Cells[0].Value = textInfo.ToTitleCase(txtApellido.Text.ToLower());
                dtgvCliente.Rows[n].Cells[1].Value = textInfo.ToTitleCase(txtNombre.Text.ToLower());
                dtgvCliente.Rows[n].Cells[2].Value = dateTimePicker1.Text;

                if(rdbHombre.Checked)dtgvCliente.Rows[n].Cells[3].Value = "Hombre";
                else dtgvCliente.Rows[n].Cells[3].Value = "Mujer";

                dtgvCliente.Rows[n].Cells[4].Value = "Eliminar";

                if (Decimal.Parse(txtSaldo.Text) < 50)
                {
                    dtgvCliente.Rows[n].DefaultCellStyle.BackColor = Color.Red;
                }
                dtgvCliente.Rows[n].Cells[5].Value = Decimal.Parse(txtSaldo.Text);

                                    
                /*GUARDAR IMAGEN*/
                string rutaImagen = txtFoto.Text;
                // Establecer la ruta de destino en la carpeta "Images" dentro del proyecto
                string projectDirectory = AppDomain.CurrentDomain.BaseDirectory; // Directorio base del proyecto
                string imagesDirectory = Path.Combine(projectDirectory, "Fotos");
                // Obtener el nombre del archivo
                string fileName = Path.GetFileName(rutaImagen+ dateTimePicker1.ToString());
                // Establecer la ruta de destino completa
                string destinationFilePath = Path.Combine(imagesDirectory, fileName);
                // Copiar la imagen al directorio de destino
                File.Copy(rutaImagen, destinationFilePath, true); // El tercer parámetro (true) permite sobrescribir si el archivo ya existe


                Image imagen = Image.FromFile(destinationFilePath);
                dtgvCliente.Rows[n].Cells[6].Value = imagen;


                dtgvCliente.Rows[n].Cells[7].Value = destinationFilePath;
                string imagePath = pictureBox1.ImageLocation;

                limpiarCampos();
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
                        MessageBox.Show("El Cliente: " + cliente + " se eliminó correctamente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Ruta de la imagen que se desea eliminar
                        //imagePathCelda = (string)dtgvCliente.Rows[n].Cells[7].Value;
                        //MessageBox.Show("Ruta: " + imagePathCelda, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dtgvCliente.Rows.RemoveAt(n);
                        limpiarCampos();
                    }

                }
                if (!string.IsNullOrEmpty(dato) && e.ColumnIndex != 4)
                {
                    txtApellido.Text = dtgvCliente.Rows[n].Cells[0].Value.ToString();
                    txtNombre.Text = dtgvCliente.Rows[n].Cells[1].Value.ToString();
                    dateTimePicker1.Value = Convert.ToDateTime(dtgvCliente.Rows[n].Cells[2].Value.ToString());
                    if (dtgvCliente.Rows[n].Cells[2].Value.ToString() == "Hombre") rdbHombre.Checked = true;
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
