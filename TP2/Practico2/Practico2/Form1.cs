using Microsoft.VisualBasic;

namespace Practico2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un n�mero y no es una tecla de control (como backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Si no es un n�mero, cancela el evento KeyPress
            }
        }

        private void TApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es Letra/Borrar/Espacio. Evitadno n�meros y caracteres especiales
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;// Si es un n�mero, cancela el evento KeyPress
            }
        }

        private void TNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es Letra/Borrar/Espacio. Evitadno n�meros y caracteres especiales
            if(!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;// Si es un n�mero, cancela el evento KeyPress
            }
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(TDni.Text) || string.IsNullOrEmpty(TNombre.Text) || string.IsNullOrEmpty(TApellido.Text))
            {
                MessageBox.Show("Debe completar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult ask = MessageBox.Show("Seguro que quiere insertar un nuevo cliente?", "Confirmar insercion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == DialogResult.Yes)
                {
                    LModificar.Text = TApellido.Text + " " + TNombre.Text;
                    MessageBox.Show("El Cliente: " + LModificar.Text + " se insert� correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            if (string.Equals(LModificar.Text, "modificar"))
            {
                MessageBox.Show("No hay clientes registrados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                DialogResult ask = MessageBox.Show("Est� a punto de eliminar al Cliente: " + LModificar.Text, "Confirmar Eliminaci�n", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (ask == DialogResult.Yes)
                {
                    MessageBox.Show("El Cliente: " + LModificar.Text + " se elimin� correctamente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LModificar.Text = "modificar";
                    TDni.Clear();
                    TApellido.Clear();
                    TNombre.Clear();
                }
            }
        }
    }
}
