namespace NetCoreFundamentos
{
    partial class Form22MascotasFiles
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
            btnNuevaMascota = new Button();
            Nombre = new Label();
            txtnombre = new TextBox();
            txtRaza = new TextBox();
            label2 = new Label();
            btnReadFile = new Button();
            btnWriteFile = new Button();
            label3 = new Label();
            lstMascotas = new ListBox();
            SuspendLayout();
            // 
            // btnNuevaMascota
            // 
            btnNuevaMascota.Location = new Point(25, 126);
            btnNuevaMascota.Name = "btnNuevaMascota";
            btnNuevaMascota.Size = new Size(100, 30);
            btnNuevaMascota.TabIndex = 0;
            btnNuevaMascota.Text = "Nueva Mascota";
            btnNuevaMascota.UseVisualStyleBackColor = true;
            btnNuevaMascota.Click += btnNuevaMascota_Click;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(25, 23);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(51, 15);
            Nombre.TabIndex = 1;
            Nombre.Text = "Nombre";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(25, 41);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(100, 23);
            txtnombre.TabIndex = 2;
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(25, 97);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(100, 23);
            txtRaza.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 79);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 3;
            label2.Text = "Raza";
            // 
            // btnReadFile
            // 
            btnReadFile.Location = new Point(25, 162);
            btnReadFile.Name = "btnReadFile";
            btnReadFile.Size = new Size(100, 30);
            btnReadFile.TabIndex = 5;
            btnReadFile.Text = "Read File";
            btnReadFile.UseVisualStyleBackColor = true;
            btnReadFile.Click += btnReadFile_Click_1;
            // 
            // btnWriteFile
            // 
            btnWriteFile.Location = new Point(25, 198);
            btnWriteFile.Name = "btnWriteFile";
            btnWriteFile.Size = new Size(100, 30);
            btnWriteFile.TabIndex = 6;
            btnWriteFile.Text = "Write File";
            btnWriteFile.UseVisualStyleBackColor = true;
            btnWriteFile.Click += btnWriteFile_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(174, 23);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 7;
            label3.Text = "Mascota";
            // 
            // lstMascotas
            // 
            lstMascotas.FormattingEnabled = true;
            lstMascotas.Location = new Point(174, 41);
            lstMascotas.Name = "lstMascotas";
            lstMascotas.Size = new Size(200, 289);
            lstMascotas.TabIndex = 8;
            lstMascotas.SelectedIndexChanged += lstMascotas_SelectedIndexChanged;
            // 
            // Form22MascotasFiles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 450);
            Controls.Add(lstMascotas);
            Controls.Add(label3);
            Controls.Add(btnWriteFile);
            Controls.Add(btnReadFile);
            Controls.Add(txtRaza);
            Controls.Add(label2);
            Controls.Add(txtnombre);
            Controls.Add(Nombre);
            Controls.Add(btnNuevaMascota);
            Name = "Form22MascotasFiles";
            Text = "Form22MascotasFiles";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNuevaMascota;
        private Label Nombre;
        private TextBox txtnombre;
        private TextBox txtRaza;
        private Label label2;
        private Button btnReadFile;
        private Button btnWriteFile;
        private Label label3;
        private ListBox lstMascotas;
    }
}