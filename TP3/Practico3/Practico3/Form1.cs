using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S) 
            {
                btnSalir.PerformClick();
            }
        }

        private void rbVaron_CheckedChanged(object sender, EventArgs e)
        {
            if (rbVaron.Checked)
            {
                //Image img1 = Image.FromFile("varon.png");
                //pictureBox1.Image = img1;
                pictureBox1.Image = Practico3.Properties.Resources.varon;
                
            }
        }


        private void rbMujer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMujer.Checked)
            {
                //Image img2 = Image.FromFile("female.png");
                //pictureBox1.Image = img2;
                pictureBox1.Image = Practico3.Properties.Resources.mujer;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TDni.Text) || string.IsNullOrEmpty(TApellido.Text) || string.IsNullOrEmpty(TNombre.Text))
            {
                MessageBox.Show("Debe comletar los campos obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                DialogResult ask = MessageBox.Show("Seguro que quiere insertar un nuevo cliente?", "Confirmar insercion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == DialogResult.Yes)
                {
                    LModificar.Text = TApellido.Text + " " + TNombre.Text;
                    MessageBox.Show("El Cliente: " + LModificar.Text + " se insertó correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.Equals(LModificar.Text, "modificar"))
            {
                MessageBox.Show("No hay clientes registrados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult ask = MessageBox.Show("Está a punto de eliminar al Cliente: " + LModificar.Text, "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (ask == DialogResult.Yes)
                {
                    MessageBox.Show("El Cliente: " + LModificar.Text + " se eliminó correctamente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LModificar.Text = "modificar";
                    TDni.Clear();
                    TApellido.Clear();
                    TNombre.Clear();
                    TTelefono.Clear();
                    CNaranja.Checked = false;
                    CVisa.Checked = false;
                    CMasterCard.Checked = false;
                }
            }
        }

        private void TDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un número y no es una tecla de control (como backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Si no es un número, cancela el evento KeyPress
            }
        }

        private void TApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es Letra/Borrar/Espacio. Evitadno números y caracteres especiales
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;// Si es un número, cancela el evento KeyPress
            }
        }

        private void TNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es Letra/Borrar/Espacio. Evitadno números y caracteres especiales
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;// Si es un número, cancela el evento KeyPress
            }
        }
    }
}
