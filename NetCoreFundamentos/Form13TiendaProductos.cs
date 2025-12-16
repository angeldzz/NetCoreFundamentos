using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form13TiendaProductos : Form
    {
        public Form13TiendaProductos()
        {
            InitializeComponent();
            this.listTienda.SelectionMode = SelectionMode.MultiSimple;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            string elem = this.txtProducto.Text;
            if (this.listTienda.Items.Contains(elem))
            {
                int indiceElemento = this.listTienda.Items.IndexOf(elem);
                this.listTienda.SelectedIndex = indiceElemento;
                MessageBox.Show("Producto Existente en la posición: " + indiceElemento);
            }
            else
            {
                this.listTienda.Items.Add(elem);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int numelementos = this.listTienda.SelectedIndices.Count;
            for (int i = numelementos - 1; i >= 0; i--)
            {
                int index = this.listTienda.SelectedIndices[i];
                this.listTienda.Items.RemoveAt(index);
            }
        }
        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            this.listTienda.Items.Clear();
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            for (int i = this.listTienda.SelectedIndices.Count - 1; i >= 0; i--)
            {
                int index = this.listTienda.SelectedIndices[i];
                string elemento = this.listTienda.Items[index].ToString();
                this.listAlmacen.Items.Add(elemento);
                this.listTienda.Items.RemoveAt(index);
            }
        }
        private void btnTodos_Click(object sender, EventArgs e)
        {
            foreach (string elemento in this.listTienda.Items)
            {
                this.listAlmacen.Items.Add(elemento);
            }
            this.listTienda.Items.Clear();
        }
    }
}
