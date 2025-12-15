using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form03DiaNacimiento : Form
    {
        public Form03DiaNacimiento()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int day = int.Parse(this.txtDay.Text);
            int month = int.Parse(this.txtMonth.Text);
            int year = int.Parse(this.txtYear.Text);

            if (month == 1)
            {
                month = 13;
                year--;
            }else if (month == 2)
            {
                month = 14;
                year-= 1;
            }

            int op1 = (month + 1) * 3 / 5;
            int op2 = year / 4;
            int op3 = year / 100;
            int op4 = year / 400;
            int op5 = day + (month * 2) + year + op1 + op2 - op3 + op4 + 2;
            int op6 = op5 / 7;
            int resultado = op5 - (op6 * 7);
            string dia = "";

            if (resultado == 0)
            {
                dia = "Sabado";
            }
            else if (resultado == 1)
            {
                dia = "Domingo";
            }
            else if (resultado == 2)
            {
                dia = "Lunes";
            }
            else if (resultado == 3)
            {
                dia = "Martes";
            }
            else if (resultado == 4)
            {
                dia = "Miercoles";
            }
            else if (resultado == 5)
            {
                dia = "Jueves";
            }
            else if (resultado == 6)
            {
                dia = "Viernes";
            }
            else
            {
                dia = "No es correcto";
            }
            lblDay.Text = "El dia de hoy es " + dia;
        }
    }
}
