namespace NetCoreFundamentos
{
    partial class Form07SumarString
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
            txtNumeros = new TextBox();
            lblResultado = new Label();
            btnSumar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(186, 28);
            label1.TabIndex = 0;
            label1.Text = "Introduzca numeros";
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(12, 40);
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(252, 23);
            txtNumeros.TabIndex = 1;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 15F);
            lblResultado.ForeColor = Color.CornflowerBlue;
            lblResultado.Location = new Point(12, 114);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(98, 28);
            lblResultado.TabIndex = 2;
            lblResultado.Text = "Resultado";
            // 
            // btnSumar
            // 
            btnSumar.Font = new Font("Segoe UI", 15F);
            btnSumar.Location = new Point(41, 67);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(157, 44);
            btnSumar.TabIndex = 3;
            btnSumar.Text = "Sumar numeros";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // Form07SumarString
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 240);
            Controls.Add(btnSumar);
            Controls.Add(lblResultado);
            Controls.Add(txtNumeros);
            Controls.Add(label1);
            Name = "Form07SumarString";
            Text = "Form07SumarString";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumeros;
        private Label lblResultado;
        private Button btnSumar;
    }
}