namespace NetCoreFundamentos
{
    partial class Form13TiendaProductos
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
            txtProducto = new TextBox();
            btnNuevo = new Button();
            btnBorrarTodo = new Button();
            btnBorrar = new Button();
            listTienda = new ListBox();
            label2 = new Label();
            label3 = new Label();
            listAlmacen = new ListBox();
            btnSeleccion = new Button();
            btnTodos = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(93, 28);
            label1.TabIndex = 0;
            label1.Text = "Producto";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(12, 40);
            txtProducto.Multiline = true;
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(123, 37);
            txtProducto.TabIndex = 1;
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Segoe UI", 15F);
            btnNuevo.Location = new Point(12, 83);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(144, 37);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.Font = new Font("Segoe UI", 15F);
            btnBorrarTodo.Location = new Point(12, 169);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(144, 37);
            btnBorrarTodo.TabIndex = 3;
            btnBorrarTodo.Text = "Borrar Todo";
            btnBorrarTodo.UseVisualStyleBackColor = true;
            btnBorrarTodo.Click += btnBorrarTodo_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Font = new Font("Segoe UI", 15F);
            btnBorrar.Location = new Point(12, 126);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(144, 37);
            btnBorrar.TabIndex = 4;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // listTienda
            // 
            listTienda.FormattingEnabled = true;
            listTienda.Location = new Point(231, 40);
            listTienda.Name = "listTienda";
            listTienda.Size = new Size(182, 319);
            listTienda.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(231, 9);
            label2.Name = "label2";
            label2.Size = new Size(70, 28);
            label2.TabIndex = 6;
            label2.Text = "Tienda";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(535, 9);
            label3.Name = "label3";
            label3.Size = new Size(87, 28);
            label3.TabIndex = 7;
            label3.Text = "Almacen";
            // 
            // listAlmacen
            // 
            listAlmacen.FormattingEnabled = true;
            listAlmacen.Location = new Point(535, 40);
            listAlmacen.Name = "listAlmacen";
            listAlmacen.Size = new Size(182, 319);
            listAlmacen.TabIndex = 8;
            // 
            // btnSeleccion
            // 
            btnSeleccion.Font = new Font("Segoe UI", 15F);
            btnSeleccion.Location = new Point(419, 147);
            btnSeleccion.Name = "btnSeleccion";
            btnSeleccion.Size = new Size(109, 37);
            btnSeleccion.TabIndex = 9;
            btnSeleccion.Text = "Seleccion";
            btnSeleccion.UseVisualStyleBackColor = true;
            btnSeleccion.Click += btnSeleccion_Click;
            // 
            // btnTodos
            // 
            btnTodos.Font = new Font("Segoe UI", 15F);
            btnTodos.Location = new Point(419, 203);
            btnTodos.Name = "btnTodos";
            btnTodos.Size = new Size(109, 37);
            btnTodos.TabIndex = 10;
            btnTodos.Text = "Todos";
            btnTodos.UseVisualStyleBackColor = true;
            btnTodos.Click += btnTodos_Click;
            // 
            // Form13TiendaProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 450);
            Controls.Add(btnTodos);
            Controls.Add(btnSeleccion);
            Controls.Add(listAlmacen);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listTienda);
            Controls.Add(btnBorrar);
            Controls.Add(btnBorrarTodo);
            Controls.Add(btnNuevo);
            Controls.Add(txtProducto);
            Controls.Add(label1);
            Name = "Form13TiendaProductos";
            Text = "Form13TiendaProductos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtProducto;
        private Button btnNuevo;
        private Button btnBorrarTodo;
        private Button btnBorrar;
        private ListBox listTienda;
        private Label label2;
        private Label label3;
        private ListBox listAlmacen;
        private Button btnSeleccion;
        private Button btnTodos;
    }
}