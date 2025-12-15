using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form05Char : Form
    {
        public Form05Char()
        {
            InitializeComponent();
        }

        private void btnRunAsci_Click(object sender, EventArgs e)
        {
            string cadena = "Visual Studio";
            int posicion = cadena.LastIndexOf("i", 10); //1
            cadena = "hola cara cola";
            string subcadena = cadena.Substring(6); //ara cola
            string subcadenacortada = cadena.Substring(6, 3); //ara
            cadena = "@@@hola coc@a co@la @@@";
            string quitaArrobaInicioFin = cadena.Trim('@');// hola coc@a co@la
            string quitaArrobaTodos = cadena.Remove('@');// hola coca cola
            string remplazosEnCadena = cadena.Replace("coca","cara");
            for (int i = 0; i < 255; i++)
            {
                char caracter = (char) i;
                //Convertimos cada numero a su char correspondiente
                if (char.IsLetter(caracter) == true)
                {
                    this.txtLetras.Text = this.txtLetras.Text + caracter;
                }
                else if(char.IsNumber(caracter) == true)
                {
                    this.txtNumeros.Text += caracter;
                }
                else if (char.IsSymbol(caracter) == true)
                {
                    this.txtSimbolos.Text += caracter;
                }
                else if (char.IsPunctuation(caracter) == true)
                {
                    this.txtPuntuacion.Text += caracter;
                }
            }
        }
    }
}
