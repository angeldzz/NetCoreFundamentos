namespace NetCoreFundamentos
{
    partial class Form24ColeccionMascotaXML
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
            txtEdad = new TextBox();
            Edad = new Label();
            txtRaza = new TextBox();
            Raza = new Label();
            txtNombre = new TextBox();
            Nombre = new Label();
            label1 = new Label();
            lstMascotas = new ListBox();
            btnLeerMascotas = new Button();
            btnGuardarMascotas = new Button();
            btnNuevaMascota = new Button();
            openFileDialog1 = new OpenFileDialog();
            pictureBox1 = new PictureBox();
            btnExaminar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(12, 145);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 13;
            // 
            // Edad
            // 
            Edad.AutoSize = true;
            Edad.Location = new Point(12, 127);
            Edad.Name = "Edad";
            Edad.Size = new Size(33, 15);
            Edad.TabIndex = 12;
            Edad.Text = "Edad";
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(12, 86);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(100, 23);
            txtRaza.TabIndex = 11;
            // 
            // Raza
            // 
            Raza.AutoSize = true;
            Raza.Location = new Point(12, 68);
            Raza.Name = "Raza";
            Raza.Size = new Size(31, 15);
            Raza.TabIndex = 10;
            Raza.Text = "Raza";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 31);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 9;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(12, 13);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(51, 15);
            Nombre.TabIndex = 8;
            Nombre.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(154, 13);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 14;
            label1.Text = "Mascotas";
            // 
            // lstMascotas
            // 
            lstMascotas.FormattingEnabled = true;
            lstMascotas.Location = new Point(154, 31);
            lstMascotas.Name = "lstMascotas";
            lstMascotas.Size = new Size(202, 199);
            lstMascotas.TabIndex = 15;
            lstMascotas.SelectedIndexChanged += lstMascotas_SelectedIndexChanged;
            // 
            // btnLeerMascotas
            // 
            btnLeerMascotas.Location = new Point(377, 30);
            btnLeerMascotas.Name = "btnLeerMascotas";
            btnLeerMascotas.Size = new Size(135, 42);
            btnLeerMascotas.TabIndex = 16;
            btnLeerMascotas.Text = "Leer Mascotas";
            btnLeerMascotas.UseVisualStyleBackColor = true;
            btnLeerMascotas.Click += btnLeerMascotas_Click;
            // 
            // btnGuardarMascotas
            // 
            btnGuardarMascotas.Location = new Point(377, 100);
            btnGuardarMascotas.Name = "btnGuardarMascotas";
            btnGuardarMascotas.Size = new Size(135, 42);
            btnGuardarMascotas.TabIndex = 17;
            btnGuardarMascotas.Text = "Guardar Mascotas";
            btnGuardarMascotas.UseVisualStyleBackColor = true;
            btnGuardarMascotas.Click += btnGuardarMascotas_Click;
            // 
            // btnNuevaMascota
            // 
            btnNuevaMascota.Location = new Point(12, 188);
            btnNuevaMascota.Name = "btnNuevaMascota";
            btnNuevaMascota.Size = new Size(135, 42);
            btnNuevaMascota.TabIndex = 18;
            btnNuevaMascota.Text = "Nueva Mascotas";
            btnNuevaMascota.UseVisualStyleBackColor = true;
            btnNuevaMascota.Click += btnNuevaMascota_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(527, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 199);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // btnExaminar
            // 
            btnExaminar.Location = new Point(377, 157);
            btnExaminar.Name = "btnExaminar";
            btnExaminar.Size = new Size(135, 40);
            btnExaminar.TabIndex = 20;
            btnExaminar.Text = "Examinar...";
            btnExaminar.UseVisualStyleBackColor = true;
            btnExaminar.Click += btnExaminar_Click;
            // 
            // Form24ColeccionMascotaXML
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 261);
            Controls.Add(btnExaminar);
            Controls.Add(pictureBox1);
            Controls.Add(btnNuevaMascota);
            Controls.Add(btnGuardarMascotas);
            Controls.Add(btnLeerMascotas);
            Controls.Add(lstMascotas);
            Controls.Add(label1);
            Controls.Add(txtEdad);
            Controls.Add(Edad);
            Controls.Add(txtRaza);
            Controls.Add(Raza);
            Controls.Add(txtNombre);
            Controls.Add(Nombre);
            Name = "Form24ColeccionMascotaXML";
            Text = "Form24ColeccionMascotaXML";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEdad;
        private Label Edad;
        private TextBox txtRaza;
        private Label Raza;
        private TextBox txtNombre;
        private Label Nombre;
        private Label label1;
        private ListBox lstMascotas;
        private Button btnLeerMascotas;
        private Button btnGuardarMascotas;
        private Button btnNuevaMascota;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox1;
        private Button btnExaminar;
    }
}