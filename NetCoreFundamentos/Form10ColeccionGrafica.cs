using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form10ColeccionGrafica : Form
    {
        public Form10ColeccionGrafica()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string elem = this.txtNuevoElemento.Text;
            this.lstElementos.Items.Add(elem);
            this.txtNuevoElemento.Clear();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Recuperamos el elemento seleccionado de la lista
            string elemSeleccionado = this.lstElementos.SelectedItem.ToString();
            //Eliminamos el objeto de la coleccion
            this.lstElementos.Items.Remove(elemSeleccionado);
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {

            this.lstElementos.Items.Clear();
        }

        private void lstElementos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstElementos.SelectedIndex != -1)
            {
                this.lblindex.Text = this.lstElementos.SelectedIndex.ToString();
                this.lblItem.Text = this.lstElementos.SelectedItem.ToString();
            }
        }
    }
}
