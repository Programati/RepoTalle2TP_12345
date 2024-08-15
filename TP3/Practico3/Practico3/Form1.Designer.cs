namespace Practico3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CMasterCard = new System.Windows.Forms.CheckBox();
            this.CVisa = new System.Windows.Forms.CheckBox();
            this.CNaranja = new System.Windows.Forms.CheckBox();
            this.TTelefono = new System.Windows.Forms.TextBox();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.TApellido = new System.Windows.Forms.TextBox();
            this.TDni = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LTelefono = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.LDni = new System.Windows.Forms.Label();
            this.LModificar = new System.Windows.Forms.Label();
            this.LNyA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbVaron = new System.Windows.Forms.RadioButton();
            this.rbMujer = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.CMasterCard);
            this.panel1.Controls.Add(this.CVisa);
            this.panel1.Controls.Add(this.CNaranja);
            this.panel1.Controls.Add(this.TTelefono);
            this.panel1.Controls.Add(this.TNombre);
            this.panel1.Controls.Add(this.TApellido);
            this.panel1.Controls.Add(this.TDni);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.LTelefono);
            this.panel1.Controls.Add(this.LNombre);
            this.panel1.Controls.Add(this.LApellido);
            this.panel1.Controls.Add(this.LDni);
            this.panel1.Controls.Add(this.LModificar);
            this.panel1.Controls.Add(this.LNyA);
            this.panel1.Location = new System.Drawing.Point(12, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 289);
            this.panel1.TabIndex = 0;
            // 
            // CMasterCard
            // 
            this.CMasterCard.AutoSize = true;
            this.CMasterCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMasterCard.Location = new System.Drawing.Point(161, 235);
            this.CMasterCard.Name = "CMasterCard";
            this.CMasterCard.Size = new System.Drawing.Size(96, 20);
            this.CMasterCard.TabIndex = 16;
            this.CMasterCard.Text = "MasterCard";
            this.CMasterCard.UseVisualStyleBackColor = true;
            // 
            // CVisa
            // 
            this.CVisa.AutoSize = true;
            this.CVisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CVisa.Location = new System.Drawing.Point(161, 209);
            this.CVisa.Name = "CVisa";
            this.CVisa.Size = new System.Drawing.Size(53, 20);
            this.CVisa.TabIndex = 15;
            this.CVisa.Text = "Visa";
            this.CVisa.UseVisualStyleBackColor = true;
            // 
            // CNaranja
            // 
            this.CNaranja.AutoSize = true;
            this.CNaranja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CNaranja.Location = new System.Drawing.Point(161, 183);
            this.CNaranja.Name = "CNaranja";
            this.CNaranja.Size = new System.Drawing.Size(74, 20);
            this.CNaranja.TabIndex = 14;
            this.CNaranja.Text = "Naranja";
            this.CNaranja.UseVisualStyleBackColor = true;
            // 
            // TTelefono
            // 
            this.TTelefono.Location = new System.Drawing.Point(97, 126);
            this.TTelefono.Name = "TTelefono";
            this.TTelefono.Size = new System.Drawing.Size(160, 20);
            this.TTelefono.TabIndex = 13;
            // 
            // TNombre
            // 
            this.TNombre.Location = new System.Drawing.Point(97, 100);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(160, 20);
            this.TNombre.TabIndex = 12;
            this.TNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TNombre_KeyPress);
            // 
            // TApellido
            // 
            this.TApellido.Location = new System.Drawing.Point(97, 74);
            this.TApellido.Name = "TApellido";
            this.TApellido.Size = new System.Drawing.Size(160, 20);
            this.TApellido.TabIndex = 11;
            this.TApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TApellido_KeyPress);
            // 
            // TDni
            // 
            this.TDni.Location = new System.Drawing.Point(97, 48);
            this.TDni.Name = "TDni";
            this.TDni.Size = new System.Drawing.Size(160, 20);
            this.TDni.TabIndex = 10;
            this.TDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TDni_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tarjeta de Creditos:";
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTelefono.Location = new System.Drawing.Point(14, 128);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(61, 16);
            this.LTelefono.TabIndex = 5;
            this.LTelefono.Text = "Teléfono";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombre.Location = new System.Drawing.Point(14, 102);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(61, 16);
            this.LNombre.TabIndex = 4;
            this.LNombre.Text = "*Nombre";
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApellido.Location = new System.Drawing.Point(14, 77);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(62, 16);
            this.LApellido.TabIndex = 3;
            this.LApellido.Text = "*Apellido";
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDni.Location = new System.Drawing.Point(14, 48);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(35, 16);
            this.LDni.TabIndex = 2;
            this.LDni.Text = "*DNI";
            // 
            // LModificar
            // 
            this.LModificar.AutoSize = true;
            this.LModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LModificar.ForeColor = System.Drawing.Color.Red;
            this.LModificar.Location = new System.Drawing.Point(131, 9);
            this.LModificar.Name = "LModificar";
            this.LModificar.Size = new System.Drawing.Size(62, 16);
            this.LModificar.TabIndex = 1;
            this.LModificar.Text = "modificar";
            // 
            // LNyA
            // 
            this.LNyA.AutoSize = true;
            this.LNyA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNyA.Location = new System.Drawing.Point(3, 9);
            this.LNyA.Name = "LNyA";
            this.LNyA.Size = new System.Drawing.Size(122, 16);
            this.LNyA.TabIndex = 0;
            this.LNyA.Text = "Nombre y Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(167, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nuevo Cliente";
            // 
            // rbVaron
            // 
            this.rbVaron.AutoSize = true;
            this.rbVaron.Checked = true;
            this.rbVaron.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVaron.Location = new System.Drawing.Point(331, 305);
            this.rbVaron.Name = "rbVaron";
            this.rbVaron.Size = new System.Drawing.Size(61, 20);
            this.rbVaron.TabIndex = 3;
            this.rbVaron.TabStop = true;
            this.rbVaron.Text = "Varon";
            this.rbVaron.UseVisualStyleBackColor = true;
            this.rbVaron.CheckedChanged += new System.EventHandler(this.rbVaron_CheckedChanged);
            // 
            // rbMujer
            // 
            this.rbMujer.AutoSize = true;
            this.rbMujer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMujer.Location = new System.Drawing.Point(423, 306);
            this.rbMujer.Name = "rbMujer";
            this.rbMujer.Size = new System.Drawing.Size(58, 20);
            this.rbMujer.TabIndex = 4;
            this.rbMujer.Text = "Mujer";
            this.rbMujer.UseVisualStyleBackColor = true;
            this.rbMujer.CheckedChanged += new System.EventHandler(this.rbMujer_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(423, 276);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(58, 20);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.Text = "Mujer";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Practico3.Properties.Resources.varon;
            this.pictureBox1.Location = new System.Drawing.Point(344, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::Practico3.Properties.Resources.icons8_salida_de_emergencia_48;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(397, 408);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(84, 57);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = global::Practico3.Properties.Resources.icons8_retire_hombre_usuario_48;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(163, 408);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(119, 57);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::Practico3.Properties.Resources.icons8_guardar_como_48;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(12, 408);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(119, 57);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 523);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.rbMujer);
            this.Controls.Add(this.rbVaron);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pequeño Formulario";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LModificar;
        private System.Windows.Forms.Label LNyA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LTelefono;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.TextBox TTelefono;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.TextBox TApellido;
        private System.Windows.Forms.TextBox TDni;
        private System.Windows.Forms.CheckBox CMasterCard;
        private System.Windows.Forms.CheckBox CVisa;
        private System.Windows.Forms.CheckBox CNaranja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbVaron;
        private System.Windows.Forms.RadioButton rbMujer;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

