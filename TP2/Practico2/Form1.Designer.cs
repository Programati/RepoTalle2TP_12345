namespace Practico2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LDni = new Label();
            LNombre = new Label();
            LApellido = new Label();
            LNya = new Label();
            LModificar = new Label();
            TDni = new TextBox();
            TNombre = new TextBox();
            TApellido = new TextBox();
            BGuardar = new Button();
            BEliminar = new Button();
            SuspendLayout();
            // 
            // LDni
            // 
            LDni.AutoSize = true;
            LDni.Location = new Point(15, 88);
            LDni.Name = "LDni";
            LDni.Size = new Size(27, 15);
            LDni.TabIndex = 0;
            LDni.Text = "DNI";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(15, 177);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(51, 15);
            LNombre.TabIndex = 1;
            LNombre.Text = "Nombre";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(15, 131);
            LApellido.Name = "LApellido";
            LApellido.RightToLeft = RightToLeft.No;
            LApellido.Size = new Size(51, 15);
            LApellido.TabIndex = 2;
            LApellido.Text = "Apellido";
            // 
            // LNya
            // 
            LNya.AutoSize = true;
            LNya.Location = new Point(12, 34);
            LNya.Name = "LNya";
            LNya.Size = new Size(110, 15);
            LNya.TabIndex = 3;
            LNya.Text = "Nombre y Apellido:";
            // 
            // LModificar
            // 
            LModificar.AutoSize = true;
            LModificar.ForeColor = Color.Red;
            LModificar.Location = new Point(128, 34);
            LModificar.Name = "LModificar";
            LModificar.Size = new Size(58, 15);
            LModificar.TabIndex = 4;
            LModificar.Text = "modificar";
            // 
            // TDni
            // 
            TDni.Location = new Point(72, 80);
            TDni.Name = "TDni";
            TDni.Size = new Size(156, 23);
            TDni.TabIndex = 1;
            TDni.KeyPress += TDni_KeyPress;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(72, 169);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(156, 23);
            TNombre.TabIndex = 3;
            TNombre.KeyPress += TNombre_KeyPress;
            // 
            // TApellido
            // 
            TApellido.Location = new Point(72, 123);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(156, 23);
            TApellido.TabIndex = 2;
            TApellido.KeyPress += TApellido_KeyPress;
            // 
            // BGuardar
            // 
            BGuardar.Location = new Point(12, 247);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(90, 30);
            BGuardar.TabIndex = 4;
            BGuardar.Text = "Guardar";
            BGuardar.UseVisualStyleBackColor = true;
            BGuardar.Click += BGuardar_Click;
            // 
            // BEliminar
            // 
            BEliminar.Location = new Point(138, 247);
            BEliminar.Name = "BEliminar";
            BEliminar.Size = new Size(90, 30);
            BEliminar.TabIndex = 5;
            BEliminar.Text = "Elimi";
            BEliminar.UseVisualStyleBackColor = true;
            BEliminar.Click += BEliminar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 341);
            Controls.Add(BEliminar);
            Controls.Add(BGuardar);
            Controls.Add(TApellido);
            Controls.Add(TNombre);
            Controls.Add(TDni);
            Controls.Add(LModificar);
            Controls.Add(LNya);
            Controls.Add(LApellido);
            Controls.Add(LNombre);
            Controls.Add(LDni);
            Name = "Form1";
            Text = "Pequeño Formulario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LDni;
        private Label LNombre;
        private Label LApellido;
        private Label LNya;
        private Label LModificar;
        private TextBox TDni;
        private TextBox TNombre;
        private TextBox TApellido;
        private Button BGuardar;
        private Button BEliminar;
    }
}
