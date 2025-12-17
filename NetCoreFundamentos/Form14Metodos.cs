using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form14Metodos : Form
    {
        public Form14Metodos()
        {
            InitializeComponent();
        }
        //Recibimos un Wrapped por Valor
        void GetDobleValor(int numero)
        {
            numero = numero * 2;
        }
        void GetDobleValorRef(ref int numero)
        {
            numero = numero * 2;
        }
        void CambiarColor(Button boton)
        {
            boton.BackColor = Color.Lavender;
        }
        private void btnDobleValor_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(textBox1.Text);
            this.GetDobleValor(numero);
            this.label2.Text = numero.ToString();
        }

        private void btnDobleReferencia_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);
            this.GetDobleValorRef(ref num);
        }

        private void btnObjetoReferencia_Click(object sender, EventArgs e)
        {
            this.CambiarColor(this.btnDobleReferencia);
        }

        private void Form14Metodos_MouseMove(object sender, MouseEventArgs e)
        {
            this.lblRaton.Text = $"X: {e.X}, Y: {e.Y}";
        }


        private void txtSoloNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Tenemos una Enumeracion que nos permite acceder a los codigos del teclado Keys
            //Debemos saber el codigo ASCII de la tecla de borrar
            char teclaBorrar = (char)Keys.Back;
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != teclaBorrar)
            {
                e.Handled = true;
            }
        }

        private void txtSoloLetra_KeyPress(object sender, KeyPressEventArgs e)
        {
            char teclaBorrar = (char)Keys.Back;
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != teclaBorrar)
            {
                e.Handled = true;
            }
        }
    }
}
