namespace NetCoreFundamentos
{
    partial class Form03DiaNacimiento
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
            button1 = new Button();
            txtDay = new TextBox();
            txtMonth = new TextBox();
            txtYear = new TextBox();
            lblDay = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 0;
            label1.Text = "Dia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 1;
            label2.Text = "Mes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 2;
            label3.Text = "Año";
            // 
            // button1
            // 
            button1.Location = new Point(12, 144);
            button1.Name = "button1";
            button1.Size = new Size(133, 39);
            button1.TabIndex = 3;
            button1.Text = "Mostrar Dia";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtDay
            // 
            txtDay.Location = new Point(12, 27);
            txtDay.Name = "txtDay";
            txtDay.Size = new Size(100, 23);
            txtDay.TabIndex = 4;
            // 
            // txtMonth
            // 
            txtMonth.Location = new Point(12, 71);
            txtMonth.Name = "txtMonth";
            txtMonth.Size = new Size(100, 23);
            txtMonth.TabIndex = 5;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(12, 115);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(100, 23);
            txtYear.TabIndex = 6;
            // 
            // lblDay
            // 
            lblDay.AutoSize = true;
            lblDay.Font = new Font("Segoe UI", 20F);
            lblDay.ForeColor = Color.CornflowerBlue;
            lblDay.Location = new Point(12, 186);
            lblDay.Name = "lblDay";
            lblDay.Size = new Size(223, 37);
            lblDay.TabIndex = 7;
            lblDay.Text = "El Dia de hoy es...";
            // 
            // Form03DiaNacimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDay);
            Controls.Add(txtYear);
            Controls.Add(txtMonth);
            Controls.Add(txtDay);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form03DiaNacimiento";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox txtDay;
        private TextBox txtMonth;
        private TextBox txtYear;
        private Label lblDay;
    }
}