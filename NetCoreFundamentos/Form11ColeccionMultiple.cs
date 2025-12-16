using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form11ColeccionMultiple : Form
    {
        public Form11ColeccionMultiple()
        {
            InitializeComponent();
            //la lista tendra seleccion multiple
            this.lstElementos.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string elem = this.txtNuevoElemento.Text;
            this.lstElementos.Items.Add(elem);
            this.txtNuevoElemento.Focus();
            this.txtNuevoElemento.SelectAll();
        }

        private void btnSeleccionados_Click(object sender, EventArgs e)
        {
            string indices = "";
            string items = "";
            //vamos a recorrer la coleccion de items seleccionados
            for (int i = 0; i < this.lstElementos.Items.Count; i++)
            {
                object cosa = this.lstElementos.Items[i];
                string texto = cosa.ToString();
            }
            // una ventaja del foreach es que podemos recorrer y hacer casting de los objetos a la vez
            // Corrección: SelectedItems contiene objetos, no necesariamente strings. Hay que usar 'var' u 'object' y llamar a ToString().
            foreach (object itemObj in this.lstElementos.SelectedItems)
            {
                items += itemObj.ToString() + ",";
            }
            // visualizamos los indices seleccionados
            // Corrección: SelectedIndices contiene enteros (int), no strings. Hay que usar 'int' y convertir a string.
            foreach (int indice in this.lstElementos.SelectedIndices)
            {
                indices += indice.ToString() + ",";
            }
            this.lblindex.Text = indices.Trim(',');
            this.lblItem.Text = items.Trim(',');
        }

        private void btnEliminarSelec_Click(object sender, EventArgs e)
        {
            //quiero eliminar los elementos seleccioados
            // para las acciones sobre las colecciones siempre
            // con bucles contador
            // voy a utilizar el metodo RemoveAt pro lo que recorremos la coleccion SelectedIndices
            
            int numElementos = this.lstElementos.SelectedIndices.Count - 1;
            for (int i = numElementos; i >= 0; i--)
            {
                    int index = this.lstElementos.SelectedIndices[i];
                    //eliminamos los que estan en la posiccion seleccionada
                    this.lstElementos.Items.RemoveAt(index);
            }
        }
    }
}

