namespace NetCoreFundamentos
{
    partial class Form10ColeccionGrafica
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
            Elementos = new Label();
            lstElementos = new ListBox();
            label2 = new Label();
            txtNuevoElemento = new TextBox();
            btnInsertar = new Button();
            btnEliminar = new Button();
            btnBorrarTodo = new Button();
            lblItem = new Label();
            lblindex = new Label();
            SuspendLayout();
            // 
            // Elementos
            // 
            Elementos.AutoSize = true;
            Elementos.Location = new Point(0, 0);
            Elementos.Name = "Elementos";
            Elementos.Size = new Size(38, 15);
            Elementos.TabIndex = 0;
            Elementos.Text = "label1";
            // 
            // lstElementos
            // 
            lstElementos.FormattingEnabled = true;
            lstElementos.Location = new Point(0, 18);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(120, 94);
            lstElementos.TabIndex = 1;
            lstElementos.SelectedIndexChanged += lstElementos_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(227, 9);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 2;
            label2.Text = "Nuevo Elemento";
            // 
            // txtNuevoElemento
            // 
            txtNuevoElemento.Location = new Point(227, 27);
            txtNuevoElemento.Name = "txtNuevoElemento";
            txtNuevoElemento.Size = new Size(141, 23);
            txtNuevoElemento.TabIndex = 3;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(227, 56);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(141, 27);
            btnInsertar.TabIndex = 4;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(227, 89);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(141, 23);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.Location = new Point(227, 118);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(141, 23);
            btnBorrarTodo.TabIndex = 6;
            btnBorrarTodo.Text = "Borrar Todo";
            btnBorrarTodo.UseVisualStyleBackColor = true;
            btnBorrarTodo.Click += btnBorrarTodo_Click;
            // 
            // lblItem
            // 
            lblItem.AutoSize = true;
            lblItem.Location = new Point(12, 152);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(32, 15);
            lblItem.TabIndex = 7;
            lblItem.Text = "-----";
            // 
            // lblindex
            // 
            lblindex.AutoSize = true;
            lblindex.Location = new Point(12, 126);
            lblindex.Name = "lblindex";
            lblindex.Size = new Size(32, 15);
            lblindex.TabIndex = 8;
            lblindex.Text = "-----";
            // 
            // Form10ColeccionGrafica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblindex);
            Controls.Add(lblItem);
            Controls.Add(btnBorrarTodo);
            Controls.Add(btnEliminar);
            Controls.Add(btnInsertar);
            Controls.Add(txtNuevoElemento);
            Controls.Add(label2);
            Controls.Add(lstElementos);
            Controls.Add(Elementos);
            Name = "Form10ColeccionGrafica";
            Text = "Form10ColeccionGrafica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Elementos;
        private ListBox lstElementos;
        private Label label2;
        private TextBox txtNuevoElemento;
        private Button btnInsertar;
        private Button btnEliminar;
        private Button btnBorrarTodo;
        private Label lblItem;
        private Label lblindex;
    }
}