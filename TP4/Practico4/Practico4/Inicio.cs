using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Practico4
{
    public partial class Inicio : Form
    {
        private Int16 desde;
        Int16 hasta;
        //Vectores para el gráfico
        string[] series = {"Pares", "Impares", "Primos","Total"};
        int[] puntos = {};
        public Inicio()
        {
            InitializeComponent();
            chart1.Titles.Add("Lista de numeros");
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtDesde.Text) || string.IsNullOrEmpty(txtHasta.Text))
            {
                MessageBox.Show("Debe ingresar números en ambos campos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lbLista.Items.Clear();
                desde = Int16.Parse(txtDesde.Text);
                hasta = Int16.Parse(txtHasta.Text);
                while(desde <= hasta)
                {
                    lbLista.Items.Add(desde);
                    desde++;
                }
            }
        }

        private void txtDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtHasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnNumPar_Click(object sender, EventArgs e)
        {
            if(lbLista.Items.Count == 0)
            {
                MessageBox.Show("Lista de números vacia!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                chart1.Series["Lista de Numeros"].Points.Clear();
                lbLista.Items.Clear();
                desde = Int16.Parse(txtDesde.Text);
                hasta = Int16.Parse(txtHasta.Text);
                int total = 0;
                int par = 0;
                while (desde <= hasta) 
                {
                    
                    if (esPar(desde))
                    {
                        lbLista.Items.Add(desde);
                        par++;
                    }
                    desde++;
                    total++;
                }
                chart1.Series["Lista de Numeros"].Points.AddXY("Pares", par);
                chart1.Series["Lista de Numeros"].Points.AddXY("Total", total);
            }
        }

        private void btnNumImpar_Click(object sender, EventArgs e)
        {
            if (lbLista.Items.Count == 0)
            {
                MessageBox.Show("Lista de números vacia!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                chart1.Series["Lista de Numeros"].Points.Clear();
                lbLista.Items.Clear();
                desde = Int16.Parse(txtDesde.Text);
                hasta = Int16.Parse(txtHasta.Text);
                int total = 0;
                int impar = 0;
                while (desde <= hasta)
                {
                    if (esImpar(desde))
                    {
                        lbLista.Items.Add(desde);
                        impar++;
                    }
                    desde++;
                    total++;
                }
                chart1.Series["Lista de Numeros"].Points.AddXY("Impares", impar);
                chart1.Series["Lista de Numeros"].Points.AddXY("Total", total);
            }
        }     
        
        private void btnNumPrimo_Click(object sender, EventArgs e)
        {
            if (lbLista.Items.Count == 0)
            {
                MessageBox.Show("Lista de números vacia!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                chart1.Series["Lista de Numeros"].Points.Clear();
                lbLista.Items.Clear();
                desde = Int16.Parse(txtDesde.Text);
                hasta = Int16.Parse(txtHasta.Text);
                int total = 0;
                int primos = 0;
                while (desde <= hasta)
                {
                    if (esPrimo(desde))
                    {
                        lbLista.Items.Add(desde);
                        primos++;
                    }
                    desde++;
                    total++;
                }
                chart1.Series["Lista de Numeros"].Points.AddXY("Primos", primos);
                chart1.Series["Lista de Numeros"].Points.AddXY("Total", total);
            }
        }

        public bool esPar(Int16 n)
        {
            return (n % 2 == 0);
        }
        public bool esImpar(Int16 n)
        {
            return (n % 2 != 0);
        }
        public bool esPrimo(Int16 n)
        {
            // Los números menores a 2 no son primos
            if (n < 2)
            {
                return false;
            }

            // Comprobamos si tiene divisores aparte de 1 y de sí mismo
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false; // No es primo si tiene algún divisor
                }
            }
            return true; // Es primo si no tiene divisores
        }
        

    }
}
