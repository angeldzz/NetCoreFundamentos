namespace NetCoreFundamentos
{
    partial class Form02ColoresPosicion
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnCambiarPosicion = new Button();
            txtPosicionX = new TextBox();
            txtPosicionY = new TextBox();
            txtRojo = new TextBox();
            txtVerde = new TextBox();
            txtAzul = new TextBox();
            btnCambiarFondo = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Posicion X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "Posicion Y";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 136);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 2;
            label3.Text = "Rojo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 180);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 3;
            label4.Text = "Verde";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 224);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 4;
            label5.Text = "Azul";
            // 
            // btnCambiarPosicion
            // 
            btnCambiarPosicion.Location = new Point(143, 34);
            btnCambiarPosicion.Name = "btnCambiarPosicion";
            btnCambiarPosicion.Size = new Size(133, 52);
            btnCambiarPosicion.TabIndex = 5;
            btnCambiarPosicion.Text = "btnCambiarPosicion";
            btnCambiarPosicion.UseVisualStyleBackColor = true;
            btnCambiarPosicion.Click += button1_Click;
            // 
            // txtPosicionX
            // 
            txtPosicionX.Location = new Point(12, 27);
            txtPosicionX.Name = "txtPosicionX";
            txtPosicionX.Size = new Size(100, 23);
            txtPosicionX.TabIndex = 6;
            // 
            // txtPosicionY
            // 
            txtPosicionY.Location = new Point(12, 71);
            txtPosicionY.Name = "txtPosicionY";
            txtPosicionY.Size = new Size(100, 23);
            txtPosicionY.TabIndex = 7;
            // 
            // txtRojo
            // 
            txtRojo.Location = new Point(12, 154);
            txtRojo.Name = "txtRojo";
            txtRojo.Size = new Size(100, 23);
            txtRojo.TabIndex = 8;
            // 
            // txtVerde
            // 
            txtVerde.Location = new Point(12, 198);
            txtVerde.Name = "txtVerde";
            txtVerde.Size = new Size(100, 23);
            txtVerde.TabIndex = 9;
            // 
            // txtAzul
            // 
            txtAzul.Location = new Point(12, 242);
            txtAzul.Name = "txtAzul";
            txtAzul.Size = new Size(100, 23);
            txtAzul.TabIndex = 10;
            // 
            // btnCambiarFondo
            // 
            btnCambiarFondo.Location = new Point(151, 188);
            btnCambiarFondo.Name = "btnCambiarFondo";
            btnCambiarFondo.Size = new Size(125, 41);
            btnCambiarFondo.TabIndex = 11;
            btnCambiarFondo.Text = "Cambiar Fondo";
            btnCambiarFondo.UseVisualStyleBackColor = true;
            btnCambiarFondo.Click += btnCambiarFondo_Click;
            // 
            // Form02ColoresPosicion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCambiarFondo);
            Controls.Add(txtAzul);
            Controls.Add(txtVerde);
            Controls.Add(txtRojo);
            Controls.Add(txtPosicionY);
            Controls.Add(txtPosicionX);
            Controls.Add(btnCambiarPosicion);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form02ColoresPosicion";
            Text = "Form02ColoresPosicion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnCambiarPosicion;
        private TextBox txtPosicionX;
        private TextBox txtPosicionY;
        private TextBox txtRojo;
        private TextBox txtVerde;
        private TextBox txtAzul;
        private Button btnCambiarFondo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}