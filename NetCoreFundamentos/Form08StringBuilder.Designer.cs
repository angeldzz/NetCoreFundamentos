namespace NetCoreFundamentos
{
    partial class Form08StringBuilder
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
            txtStringBuilder = new RichTextBox();
            btnInvertirstring = new Button();
            btnInvertirStringBuilder = new Button();
            lblTiempo = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 28);
            label1.Name = "label1";
            label1.Size = new Size(140, 15);
            label1.TabIndex = 0;
            label1.Text = "Copie texto para trabajar:";
            // 
            // txtStringBuilder
            // 
            txtStringBuilder.Location = new Point(71, 62);
            txtStringBuilder.Name = "txtStringBuilder";
            txtStringBuilder.Size = new Size(688, 276);
            txtStringBuilder.TabIndex = 1;
            txtStringBuilder.Text = "";
            // 
            // btnInvertirstring
            // 
            btnInvertirstring.Location = new Point(418, 344);
            btnInvertirstring.Name = "btnInvertirstring";
            btnInvertirstring.Size = new Size(126, 28);
            btnInvertirstring.TabIndex = 2;
            btnInvertirstring.Text = "Invertir String";
            btnInvertirstring.UseVisualStyleBackColor = true;
            btnInvertirstring.Click += btnInvertirstring_Click;
            // 
            // btnInvertirStringBuilder
            // 
            btnInvertirStringBuilder.Location = new Point(581, 344);
            btnInvertirStringBuilder.Name = "btnInvertirStringBuilder";
            btnInvertirStringBuilder.Size = new Size(178, 28);
            btnInvertirStringBuilder.TabIndex = 3;
            btnInvertirStringBuilder.Text = "Invertir String Builder";
            btnInvertirStringBuilder.UseVisualStyleBackColor = true;
            btnInvertirStringBuilder.Click += btnInvertirStringBuilder_Click;
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Font = new Font("Segoe UI", 15F);
            lblTiempo.ForeColor = Color.Crimson;
            lblTiempo.Location = new Point(71, 344);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(100, 28);
            lblTiempo.TabIndex = 4;
            lblTiempo.Text = "lblTiempo";
            // 
            // Form08StringBuilder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTiempo);
            Controls.Add(btnInvertirStringBuilder);
            Controls.Add(btnInvertirstring);
            Controls.Add(txtStringBuilder);
            Controls.Add(label1);
            Name = "Form08StringBuilder";
            Text = "Form08StringBuilder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox txtStringBuilder;
        private Button btnInvertirstring;
        private Button btnInvertirStringBuilder;
        private Label lblTiempo;
    }
}