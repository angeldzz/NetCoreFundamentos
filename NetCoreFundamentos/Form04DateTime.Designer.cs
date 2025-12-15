namespace NetCoreFundamentos
{
    partial class Form04DateTime
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
            txtFechaActual = new TextBox();
            label1 = new Label();
            chkFormato = new CheckBox();
            rdbDias = new RadioButton();
            rdbMeses = new RadioButton();
            rdbAnyos = new RadioButton();
            label2 = new Label();
            txtIncremento = new TextBox();
            btnIncrementar = new Button();
            label3 = new Label();
            txtFechaFinal = new TextBox();
            SuspendLayout();
            // 
            // txtFechaActual
            // 
            txtFechaActual.Location = new Point(12, 27);
            txtFechaActual.Name = "txtFechaActual";
            txtFechaActual.Size = new Size(748, 23);
            txtFechaActual.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 1;
            label1.Text = "Fecha Actual";
            // 
            // chkFormato
            // 
            chkFormato.AutoSize = true;
            chkFormato.Location = new Point(12, 56);
            chkFormato.Name = "chkFormato";
            chkFormato.Size = new Size(117, 19);
            chkFormato.TabIndex = 2;
            chkFormato.Text = "cambiar Formato";
            chkFormato.UseVisualStyleBackColor = true;
            // 
            // rdbDias
            // 
            rdbDias.AutoSize = true;
            rdbDias.Location = new Point(12, 81);
            rdbDias.Name = "rdbDias";
            rdbDias.Size = new Size(47, 19);
            rdbDias.TabIndex = 3;
            rdbDias.TabStop = true;
            rdbDias.Text = "Dias";
            rdbDias.UseVisualStyleBackColor = true;
            // 
            // rdbMeses
            // 
            rdbMeses.AutoSize = true;
            rdbMeses.Location = new Point(12, 104);
            rdbMeses.Name = "rdbMeses";
            rdbMeses.Size = new Size(58, 19);
            rdbMeses.TabIndex = 4;
            rdbMeses.TabStop = true;
            rdbMeses.Text = "Meses";
            rdbMeses.UseVisualStyleBackColor = true;
            // 
            // rdbAnyos
            // 
            rdbAnyos.AutoSize = true;
            rdbAnyos.Location = new Point(12, 129);
            rdbAnyos.Name = "rdbAnyos";
            rdbAnyos.Size = new Size(52, 19);
            rdbAnyos.TabIndex = 5;
            rdbAnyos.TabStop = true;
            rdbAnyos.Text = "Años";
            rdbAnyos.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(147, 104);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 6;
            label2.Text = "Incremento";
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(221, 104);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(84, 23);
            txtIncremento.TabIndex = 7;
            // 
            // btnIncrementar
            // 
            btnIncrementar.Location = new Point(147, 133);
            btnIncrementar.Name = "btnIncrementar";
            btnIncrementar.Size = new Size(158, 29);
            btnIncrementar.TabIndex = 8;
            btnIncrementar.Text = "Incrementar";
            btnIncrementar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 191);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 10;
            label3.Text = "Fecha Final";
            // 
            // txtFechaFinal
            // 
            txtFechaFinal.Location = new Point(12, 209);
            txtFechaFinal.Name = "txtFechaFinal";
            txtFechaFinal.Size = new Size(748, 23);
            txtFechaFinal.TabIndex = 9;
            // 
            // Form04DateTime
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(txtFechaFinal);
            Controls.Add(btnIncrementar);
            Controls.Add(txtIncremento);
            Controls.Add(label2);
            Controls.Add(rdbAnyos);
            Controls.Add(rdbMeses);
            Controls.Add(rdbDias);
            Controls.Add(chkFormato);
            Controls.Add(label1);
            Controls.Add(txtFechaActual);
            Name = "Form04DateTime";
            Text = "Form04DateTime";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFechaActual;
        private Label label1;
        private CheckBox chkFormato;
        private RadioButton rdbDias;
        private RadioButton rdbMeses;
        private RadioButton rdbAnyos;
        private Label label2;
        private TextBox txtIncremento;
        private Button btnIncrementar;
        private Label label3;
        private TextBox txtFechaFinal;
    }
}