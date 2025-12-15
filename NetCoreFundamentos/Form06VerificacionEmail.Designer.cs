namespace NetCoreFundamentos
{
    partial class Form06VerificacionEmail
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
            btnVerificar = new Button();
            txtEmail = new TextBox();
            lblVerificacion = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(12, 56);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(112, 33);
            btnVerificar.TabIndex = 1;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 27);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(258, 23);
            txtEmail.TabIndex = 2;
            // 
            // lblVerificacion
            // 
            lblVerificacion.AutoSize = true;
            lblVerificacion.Font = new Font("Segoe UI", 20F);
            lblVerificacion.Location = new Point(12, 102);
            lblVerificacion.Name = "lblVerificacion";
            lblVerificacion.Size = new Size(153, 37);
            lblVerificacion.TabIndex = 3;
            lblVerificacion.Text = "Verificacion";
            // 
            // Form06VerificacionEmail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblVerificacion);
            Controls.Add(txtEmail);
            Controls.Add(btnVerificar);
            Controls.Add(label1);
            Name = "Form06VerificacionEmail";
            Text = "Form06VerificacionEmail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnVerificar;
        private TextBox txtEmail;
        private Label lblVerificacion;
    }
}