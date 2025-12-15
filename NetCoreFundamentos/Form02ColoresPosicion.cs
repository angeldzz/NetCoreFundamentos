using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form02ColoresPosicion : Form
    {
        public Form02ColoresPosicion()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.btnCambiarPosicion.Location = new Point(int.Parse(txtPosicionX.Text), int.Parse(txtPosicionY.Text));
        }

        private void btnCambiarFondo_Click(object sender, EventArgs e)
        {
            int rojo = int.Parse(txtRojo.Text);
            int verde = int.Parse(txtVerde.Text);
            int azul = int.Parse(txtAzul.Text);

            if (rojo < 0 || rojo > 255)
            {
                MessageBox.Show("El valor de rojo debe estar comprendido entre 0 y 255");
            }
            else if (verde < 0 || verde > 255)
            {
                MessageBox.Show("El valor de verde debe estar comprendido entre 0 y 255");
            }
            else if (azul < 0 || azul > 255)
            {
                MessageBox.Show("El valor de azul debe estar comprendido entre 0 y 255");
            }
            else
            {
                this.BackColor = Color.FromArgb(rojo, verde, azul);
                MessageBox.Show("Estamos bien");
            }


        }
    }
}
