using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form12ColeccionNumeros : Form
    {
        public Form12ColeccionNumeros()
        {
            InitializeComponent();
        }

        private void btnGenerarNumeros_Click(object sender, EventArgs e)
        {
            this.lstNumeros.Items.Clear();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                this.lstNumeros.Items.Add(random.Next(1,100));
            }
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            int suma = 0;
            int sumaPares = 0;
            int sumaImpares = 0;
            for (int i = 0; i < this.lstNumeros.Items.Count; i++)
            {
                int numero = int.Parse(this.lstNumeros.Items[i].ToString());
                
                suma += suma + numero;
                if (numero % 2 == 0)
                {
                    sumaPares += sumaPares + numero;
                }
                else
                {
                    sumaImpares += sumaImpares + numero;

                }
            }
            this.txtSuma.Text = suma.ToString();
            this.txtPares.Text = sumaPares.ToString();
            this.txtImpares.Text = sumaImpares.ToString();
        }

    }
}
