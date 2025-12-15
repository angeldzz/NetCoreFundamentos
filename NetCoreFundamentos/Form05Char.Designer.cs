namespace NetCoreFundamentos
{
    partial class Form05Char
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
            txtLetras = new TextBox();
            txtNumeros = new TextBox();
            lblwd = new Label();
            txtSimbolos = new TextBox();
            label3 = new Label();
            txtPuntuacion = new TextBox();
            lblp = new Label();
            btnRunAsci = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 18);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "Letras";
            // 
            // txtLetras
            // 
            txtLetras.Location = new Point(28, 36);
            txtLetras.Multiline = true;
            txtLetras.Name = "txtLetras";
            txtLetras.Size = new Size(326, 168);
            txtLetras.TabIndex = 1;
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(408, 36);
            txtNumeros.Multiline = true;
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(326, 168);
            txtNumeros.TabIndex = 3;
            // 
            // lblwd
            // 
            lblwd.AutoSize = true;
            lblwd.Location = new Point(408, 18);
            lblwd.Name = "lblwd";
            lblwd.Size = new Size(56, 15);
            lblwd.TabIndex = 2;
            lblwd.Text = "Numeros";
            // 
            // txtSimbolos
            // 
            txtSimbolos.Location = new Point(28, 230);
            txtSimbolos.Multiline = true;
            txtSimbolos.Name = "txtSimbolos";
            txtSimbolos.Size = new Size(326, 168);
            txtSimbolos.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 212);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 4;
            label3.Text = "Simbolos";
            // 
            // txtPuntuacion
            // 
            txtPuntuacion.Location = new Point(408, 230);
            txtPuntuacion.Multiline = true;
            txtPuntuacion.Name = "txtPuntuacion";
            txtPuntuacion.Size = new Size(326, 168);
            txtPuntuacion.TabIndex = 7;
            // 
            // lblp
            // 
            lblp.AutoSize = true;
            lblp.Location = new Point(408, 212);
            lblp.Name = "lblp";
            lblp.Size = new Size(68, 15);
            lblp.TabIndex = 6;
            lblp.Text = "Puntuacion";
            // 
            // btnRunAsci
            // 
            btnRunAsci.Location = new Point(338, 415);
            btnRunAsci.Name = "btnRunAsci";
            btnRunAsci.Size = new Size(75, 23);
            btnRunAsci.TabIndex = 8;
            btnRunAsci.Text = "run ASCII";
            btnRunAsci.UseVisualStyleBackColor = true;
            btnRunAsci.Click += btnRunAsci_Click;
            // 
            // Form05Char
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRunAsci);
            Controls.Add(txtPuntuacion);
            Controls.Add(lblp);
            Controls.Add(txtSimbolos);
            Controls.Add(label3);
            Controls.Add(txtNumeros);
            Controls.Add(lblwd);
            Controls.Add(txtLetras);
            Controls.Add(label1);
            Name = "Form05Char";
            Text = "Form05Chart";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtLetras;
        private TextBox txtNumeros;
        private Label lblwd;
        private TextBox txtSimbolos;
        private Label label3;
        private TextBox txtPuntuacion;
        private Label lblp;
        private Button btnRunAsci;
    }
}