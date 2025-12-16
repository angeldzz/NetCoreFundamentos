namespace NetCoreFundamentos
{
    partial class Form11ColeccionMultiple
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
            lblindex = new Label();
            lblItem = new Label();
            btnBorrarTodo = new Button();
            btnEliminarSelec = new Button();
            btnInsertar = new Button();
            txtNuevoElemento = new TextBox();
            label2 = new Label();
            lstElementos = new ListBox();
            Elementos = new Label();
            btnSeleccionados = new Button();
            SuspendLayout();
            // 
            // lblindex
            // 
            lblindex.AutoSize = true;
            lblindex.Location = new Point(24, 131);
            lblindex.Name = "lblindex";
            lblindex.Size = new Size(32, 15);
            lblindex.TabIndex = 17;
            lblindex.Text = "-----";
            // 
            // lblItem
            // 
            lblItem.AutoSize = true;
            lblItem.Location = new Point(24, 157);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(32, 15);
            lblItem.TabIndex = 16;
            lblItem.Text = "-----";
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.BackColor = Color.DarkRed;
            btnBorrarTodo.Location = new Point(239, 123);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(141, 23);
            btnBorrarTodo.TabIndex = 15;
            btnBorrarTodo.Text = "Borrar Todo";
            btnBorrarTodo.UseVisualStyleBackColor = false;
            // 
            // btnEliminarSelec
            // 
            btnEliminarSelec.BackColor = Color.Crimson;
            btnEliminarSelec.Location = new Point(239, 94);
            btnEliminarSelec.Name = "btnEliminarSelec";
            btnEliminarSelec.Size = new Size(141, 23);
            btnEliminarSelec.TabIndex = 14;
            btnEliminarSelec.Text = "Eliminar Seleccionados";
            btnEliminarSelec.UseVisualStyleBackColor = false;
            btnEliminarSelec.Click += btnEliminarSelec_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(239, 61);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(141, 27);
            btnInsertar.TabIndex = 13;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // txtNuevoElemento
            // 
            txtNuevoElemento.Location = new Point(239, 32);
            txtNuevoElemento.Name = "txtNuevoElemento";
            txtNuevoElemento.Size = new Size(141, 23);
            txtNuevoElemento.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(239, 14);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 11;
            label2.Text = "Nuevo Elemento";
            // 
            // lstElementos
            // 
            lstElementos.FormattingEnabled = true;
            lstElementos.Location = new Point(12, 23);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(120, 94);
            lstElementos.TabIndex = 10;
            // 
            // Elementos
            // 
            Elementos.AutoSize = true;
            Elementos.Location = new Point(12, 5);
            Elementos.Name = "Elementos";
            Elementos.Size = new Size(38, 15);
            Elementos.TabIndex = 9;
            Elementos.Text = "label1";
            // 
            // btnSeleccionados
            // 
            btnSeleccionados.Location = new Point(239, 157);
            btnSeleccionados.Name = "btnSeleccionados";
            btnSeleccionados.Size = new Size(141, 23);
            btnSeleccionados.TabIndex = 18;
            btnSeleccionados.Text = "Seleccionados";
            btnSeleccionados.UseVisualStyleBackColor = true;
            btnSeleccionados.Click += btnSeleccionados_Click;
            // 
            // Form11ColeccionMultiple
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSeleccionados);
            Controls.Add(lblindex);
            Controls.Add(lblItem);
            Controls.Add(btnBorrarTodo);
            Controls.Add(btnEliminarSelec);
            Controls.Add(btnInsertar);
            Controls.Add(txtNuevoElemento);
            Controls.Add(label2);
            Controls.Add(lstElementos);
            Controls.Add(Elementos);
            Name = "Form11ColeccionMultiple";
            Text = "Form11ColeccionMultiple";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblindex;
        private Label lblItem;
        private Button btnBorrarTodo;
        private Button btnEliminarSelec;
        private Button btnInsertar;
        private TextBox txtNuevoElemento;
        private Label label2;
        private ListBox lstElementos;
        private Label Elementos;
        private Button btnSeleccionados;
    }
}