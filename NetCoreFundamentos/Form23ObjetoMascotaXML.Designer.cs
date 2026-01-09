namespace NetCoreFundamentos
{
    partial class Form23ObjetoMascotaXML
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Nombre = new Label();
            txtNombre = new TextBox();
            txtRaza = new TextBox();
            Raza = new Label();
            txtEdad = new TextBox();
            Edad = new Label();
            btnLeerClase = new Button();
            btnGuardarClase = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnSeleccionarImagen = new Button();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(22, 9);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(51, 15);
            Nombre.TabIndex = 0;
            Nombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(22, 27);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(22, 82);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(100, 23);
            txtRaza.TabIndex = 3;
            // 
            // Raza
            // 
            Raza.AutoSize = true;
            Raza.Location = new Point(22, 64);
            Raza.Name = "Raza";
            Raza.Size = new Size(31, 15);
            Raza.TabIndex = 2;
            Raza.Text = "Raza";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(22, 141);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 5;
            // 
            // Edad
            // 
            Edad.AutoSize = true;
            Edad.Location = new Point(22, 123);
            Edad.Name = "Edad";
            Edad.Size = new Size(33, 15);
            Edad.TabIndex = 4;
            Edad.Text = "Edad";
            // 
            // btnLeerClase
            // 
            btnLeerClase.Location = new Point(159, 18);
            btnLeerClase.Name = "btnLeerClase";
            btnLeerClase.Size = new Size(100, 32);
            btnLeerClase.TabIndex = 6;
            btnLeerClase.Text = "Leer Clase";
            btnLeerClase.UseVisualStyleBackColor = true;
            btnLeerClase.Click += btnLeerClase_Click;
            // 
            // btnGuardarClase
            // 
            btnGuardarClase.Location = new Point(159, 64);
            btnGuardarClase.Name = "btnGuardarClase";
            btnGuardarClase.Size = new Size(100, 32);
            btnGuardarClase.TabIndex = 7;
            btnGuardarClase.Text = "Guardar Clase";
            btnGuardarClase.UseVisualStyleBackColor = true;
            btnGuardarClase.Click += btnGuardarClase_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(22, 197);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(245, 177);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 179);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 9;
            label1.Text = "Imagen";
            // 
            // btnSeleccionarImagen
            // 
            btnSeleccionarImagen.Location = new Point(159, 111);
            btnSeleccionarImagen.Name = "btnSeleccionarImagen";
            btnSeleccionarImagen.Size = new Size(100, 62);
            btnSeleccionarImagen.TabIndex = 10;
            btnSeleccionarImagen.Text = "Seleccionar Imagen";
            btnSeleccionarImagen.UseVisualStyleBackColor = true;
            btnSeleccionarImagen.Click += btnSeleccionarImagen_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form23ObjetoMascotaXML
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSeleccionarImagen);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnGuardarClase);
            Controls.Add(btnLeerClase);
            Controls.Add(txtEdad);
            Controls.Add(Edad);
            Controls.Add(txtRaza);
            Controls.Add(Raza);
            Controls.Add(txtNombre);
            Controls.Add(Nombre);
            Name = "Form23ObjetoMascotaXML";
            Text = "Form23ObjetoMascotaXML";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Nombre;
        private TextBox txtNombre;
        private TextBox txtRaza;
        private Label Raza;
        private TextBox txtEdad;
        private Label Edad;
        private Button btnLeerClase;
        private Button btnGuardarClase;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnSeleccionarImagen;
        private OpenFileDialog openFileDialog1;
    }
}