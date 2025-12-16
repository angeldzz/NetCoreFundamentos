namespace NetCoreFundamentos
{
    partial class Form09ValidarISBN
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
            btnValidar = new Button();
            txtISBN = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 0;
            label1.Text = "Introduce ISBN:";
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(12, 56);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(177, 43);
            btnValidar.TabIndex = 2;
            btnValidar.Text = "Validar ISBN";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(12, 27);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(277, 23);
            txtISBN.TabIndex = 3;
            // 
            // Form09ValidarISBN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 190);
            Controls.Add(txtISBN);
            Controls.Add(btnValidar);
            Controls.Add(label1);
            Name = "Form09ValidarISBN";
            Text = "Form09ValidarISBN";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnValidar;
        private TextBox txtISBN;
    }
}