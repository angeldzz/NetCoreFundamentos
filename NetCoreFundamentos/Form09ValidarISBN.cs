using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form09ValidarISBN : Form
    {
        public Form09ValidarISBN()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string ISBN = txtISBN.Text;
            if (ISBN.Length == 10)
            {
                int longitud = ISBN.Length;
                int suma = 0;
                for (int i = 0; i < longitud; i++)
                {
                    char numeroActual = ISBN[i];
                    suma += int.Parse(numeroActual.ToString()) * (i + 1);
                }
                if ((suma % 11) == 0)
                {
                    MessageBox.Show("El ISBN es correcto!!!");
                }
                else
                {
                    MessageBox.Show("El ISBN es incorrecto, corrijalo");
                }
            }
            else
            {
                MessageBox.Show("Deben ser 10 numeros");
            }
            
        }
    }
}
