namespace Practico4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lblListaDeNumeros = new System.Windows.Forms.Label();
            this.lbLista = new System.Windows.Forms.ListBox();
            this.btnNumPar = new System.Windows.Forms.Button();
            this.btnNumImpar = new System.Windows.Forms.Button();
            this.btnNumPrimo = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDesde
            // 
            this.txtDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesde.Location = new System.Drawing.Point(82, 44);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(105, 22);
            this.txtDesde.TabIndex = 0;
            this.txtDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesde_KeyPress);
            // 
            // txtHasta
            // 
            this.txtHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHasta.Location = new System.Drawing.Point(82, 95);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(105, 22);
            this.txtHasta.TabIndex = 1;
            this.txtHasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHasta_KeyPress);
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.Location = new System.Drawing.Point(13, 44);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(48, 16);
            this.lblDesde.TabIndex = 2;
            this.lblDesde.Text = "Desde";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.Location = new System.Drawing.Point(13, 101);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(43, 16);
            this.lblHasta.TabIndex = 3;
            this.lblHasta.Text = "Hasta";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(16, 158);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(123, 30);
            this.btnGenerar.TabIndex = 4;
            this.btnGenerar.Text = "Generar Funcion";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lblListaDeNumeros
            // 
            this.lblListaDeNumeros.AutoSize = true;
            this.lblListaDeNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaDeNumeros.Location = new System.Drawing.Point(251, 32);
            this.lblListaDeNumeros.Name = "lblListaDeNumeros";
            this.lblListaDeNumeros.Size = new System.Drawing.Size(128, 16);
            this.lblListaDeNumeros.TabIndex = 5;
            this.lblListaDeNumeros.Text = "Lista de Numeros";
            // 
            // lbLista
            // 
            this.lbLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLista.FormattingEnabled = true;
            this.lbLista.ItemHeight = 16;
            this.lbLista.Location = new System.Drawing.Point(223, 51);
            this.lbLista.Name = "lbLista";
            this.lbLista.Size = new System.Drawing.Size(186, 276);
            this.lbLista.TabIndex = 6;
            // 
            // btnNumPar
            // 
            this.btnNumPar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumPar.Location = new System.Drawing.Point(16, 225);
            this.btnNumPar.Name = "btnNumPar";
            this.btnNumPar.Size = new System.Drawing.Size(123, 30);
            this.btnNumPar.TabIndex = 7;
            this.btnNumPar.Text = "Numeros Pares";
            this.btnNumPar.UseVisualStyleBackColor = true;
            this.btnNumPar.Click += new System.EventHandler(this.btnNumPar_Click);
            // 
            // btnNumImpar
            // 
            this.btnNumImpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumImpar.Location = new System.Drawing.Point(16, 261);
            this.btnNumImpar.Name = "btnNumImpar";
            this.btnNumImpar.Size = new System.Drawing.Size(123, 30);
            this.btnNumImpar.TabIndex = 8;
            this.btnNumImpar.Text = "Numeros Impares";
            this.btnNumImpar.UseVisualStyleBackColor = true;
            this.btnNumImpar.Click += new System.EventHandler(this.btnNumImpar_Click);
            // 
            // btnNumPrimo
            // 
            this.btnNumPrimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumPrimo.Location = new System.Drawing.Point(16, 297);
            this.btnNumPrimo.Name = "btnNumPrimo";
            this.btnNumPrimo.Size = new System.Drawing.Size(123, 30);
            this.btnNumPrimo.TabIndex = 9;
            this.btnNumPrimo.Text = "Numeros Primos";
            this.btnNumPrimo.UseVisualStyleBackColor = true;
            this.btnNumPrimo.Click += new System.EventHandler(this.btnNumPrimo_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(439, 51);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Lista de Numeros";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(253, 276);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 348);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnNumPrimo);
            this.Controls.Add(this.btnNumImpar);
            this.Controls.Add(this.btnNumPar);
            this.Controls.Add(this.lbLista);
            this.Controls.Add(this.lblListaDeNumeros);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.txtHasta);
            this.Controls.Add(this.txtDesde);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.TextBox txtHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label lblListaDeNumeros;
        private System.Windows.Forms.ListBox lbLista;
        private System.Windows.Forms.Button btnNumPar;
        private System.Windows.Forms.Button btnNumImpar;
        private System.Windows.Forms.Button btnNumPrimo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

