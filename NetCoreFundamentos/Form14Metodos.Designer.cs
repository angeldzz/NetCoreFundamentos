namespace NetCoreFundamentos
{
    partial class Form14Metodos
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
            textBox1 = new TextBox();
            label2 = new Label();
            btnDobleValor = new Button();
            btnDobleReferencia = new Button();
            btnObjetoReferencia = new Button();
            lblRaton = new Label();
            txtSoloLetra = new TextBox();
            label3 = new Label();
            txtSoloNumero = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 2;
            label2.Text = "lblResultado";
            // 
            // btnDobleValor
            // 
            btnDobleValor.Location = new Point(12, 93);
            btnDobleValor.Name = "btnDobleValor";
            btnDobleValor.Size = new Size(120, 23);
            btnDobleValor.TabIndex = 3;
            btnDobleValor.Text = "Doble valor";
            btnDobleValor.UseVisualStyleBackColor = true;
            btnDobleValor.Click += btnDobleValor_Click;
            // 
            // btnDobleReferencia
            // 
            btnDobleReferencia.Location = new Point(12, 122);
            btnDobleReferencia.Name = "btnDobleReferencia";
            btnDobleReferencia.Size = new Size(120, 23);
            btnDobleReferencia.TabIndex = 4;
            btnDobleReferencia.Text = "Doble Referencia";
            btnDobleReferencia.UseVisualStyleBackColor = true;
            btnDobleReferencia.Click += btnDobleReferencia_Click;
            // 
            // btnObjetoReferencia
            // 
            btnObjetoReferencia.Location = new Point(12, 151);
            btnObjetoReferencia.Name = "btnObjetoReferencia";
            btnObjetoReferencia.Size = new Size(120, 23);
            btnObjetoReferencia.TabIndex = 5;
            btnObjetoReferencia.Text = "Objeto Referencia";
            btnObjetoReferencia.UseVisualStyleBackColor = true;
            btnObjetoReferencia.Click += btnObjetoReferencia_Click;
            // 
            // lblRaton
            // 
            lblRaton.Anchor = AnchorStyles.None;
            lblRaton.BackColor = Color.DarkTurquoise;
            lblRaton.Location = new Point(149, 147);
            lblRaton.Name = "lblRaton";
            lblRaton.Size = new Size(83, 27);
            lblRaton.TabIndex = 6;
            lblRaton.Text = "lblRaton";
            lblRaton.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSoloLetra
            // 
            txtSoloLetra.Location = new Point(258, 79);
            txtSoloLetra.Name = "txtSoloLetra";
            txtSoloLetra.Size = new Size(100, 23);
            txtSoloLetra.TabIndex = 8;
            txtSoloLetra.KeyPress += txtSoloLetra_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(258, 61);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 7;
            label3.Text = "Solo Letra";
            // 
            // txtSoloNumero
            // 
            txtSoloNumero.Location = new Point(258, 27);
            txtSoloNumero.Name = "txtSoloNumero";
            txtSoloNumero.Size = new Size(100, 23);
            txtSoloNumero.TabIndex = 10;
            txtSoloNumero.KeyPress += txtSoloNumero_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(258, 9);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 9;
            label4.Text = "Solo numero";
            // 
            // Form14Metodos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 476);
            Controls.Add(txtSoloNumero);
            Controls.Add(label4);
            Controls.Add(txtSoloLetra);
            Controls.Add(label3);
            Controls.Add(lblRaton);
            Controls.Add(btnObjetoReferencia);
            Controls.Add(btnDobleReferencia);
            Controls.Add(btnDobleValor);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form14Metodos";
            Text = "Form14Metodos";
            MouseMove += Form14Metodos_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Button btnDobleValor;
        private Button btnDobleReferencia;
        private Button btnObjetoReferencia;
        private Label lblRaton;
        private TextBox txtSoloLetra;
        private Label label3;
        private TextBox txtSoloNumero;
        private Label label4;
    }
}