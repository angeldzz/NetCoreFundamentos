namespace NetCoreFundamentos
{
    partial class Form21Files
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
            label1 = new Label();
            txtContenidoFile = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            bnNuevoNombre = new Button();
            btnLeerFile = new Button();
            Nombres = new Label();
            lstNombres = new ListBox();
            btnWriteFile = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 10);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "Contenido File";
            // 
            // txtContenidoFile
            // 
            txtContenidoFile.Location = new Point(42, 38);
            txtContenidoFile.Multiline = true;
            txtContenidoFile.Name = "txtContenidoFile";
            txtContenidoFile.Size = new Size(328, 283);
            txtContenidoFile.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(419, 10);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(419, 38);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 3;
            // 
            // bnNuevoNombre
            // 
            bnNuevoNombre.Location = new Point(420, 75);
            bnNuevoNombre.Name = "bnNuevoNombre";
            bnNuevoNombre.Size = new Size(99, 26);
            bnNuevoNombre.TabIndex = 4;
            bnNuevoNombre.Text = "Nuevo Nombre";
            bnNuevoNombre.UseVisualStyleBackColor = true;
            bnNuevoNombre.Click += bnNuevoNombre_Click;
            // 
            // btnLeerFile
            // 
            btnLeerFile.Location = new Point(420, 120);
            btnLeerFile.Name = "btnLeerFile";
            btnLeerFile.Size = new Size(99, 26);
            btnLeerFile.TabIndex = 5;
            btnLeerFile.Text = "Leer File";
            btnLeerFile.UseVisualStyleBackColor = true;
            btnLeerFile.Click += btnLeerFile_Click;
            // 
            // Nombres
            // 
            Nombres.AutoSize = true;
            Nombres.Location = new Point(589, 10);
            Nombres.Name = "Nombres";
            Nombres.Size = new Size(38, 15);
            Nombres.TabIndex = 6;
            Nombres.Text = "label3";
            // 
            // lstNombres
            // 
            lstNombres.FormattingEnabled = true;
            lstNombres.Location = new Point(589, 38);
            lstNombres.Name = "lstNombres";
            lstNombres.Size = new Size(314, 259);
            lstNombres.TabIndex = 7;
            // 
            // btnWriteFile
            // 
            btnWriteFile.Location = new Point(419, 164);
            btnWriteFile.Name = "btnWriteFile";
            btnWriteFile.Size = new Size(99, 26);
            btnWriteFile.TabIndex = 8;
            btnWriteFile.Text = "Write File";
            btnWriteFile.UseVisualStyleBackColor = true;
            btnWriteFile.Click += btnWriteFile_Click;
            // 
            // Form21Files
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 450);
            Controls.Add(btnWriteFile);
            Controls.Add(lstNombres);
            Controls.Add(Nombres);
            Controls.Add(btnLeerFile);
            Controls.Add(bnNuevoNombre);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtContenidoFile);
            Controls.Add(label1);
            Name = "Form21Files";
            Text = "Form21Files";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtContenidoFile;
        private Label label2;
        private TextBox txtNombre;
        private Button bnNuevoNombre;
        private Button btnLeerFile;
        private Label Nombres;
        private ListBox lstNombres;
        private Button btnWriteFile;
    }
}