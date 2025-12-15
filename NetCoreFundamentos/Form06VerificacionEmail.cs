using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form06VerificacionEmail : Form
    {
        public Form06VerificacionEmail()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string email = this.txtEmail.Text;
            int posP = email.IndexOf(".");
            if (!email.Contains('@'))
            {
                this.lblVerificacion.Text = "Error: No contiene @";
            }
            else if (email.StartsWith("@"))
            {
                this.lblVerificacion.Text = "Error: No puede empezar en @";
            }
            else if (email.EndsWith("@"))
            {
                this.lblVerificacion.Text = "Error: No puede terminar en @";
            }
            else if (!email.Contains('.'))
            {
                this.lblVerificacion.Text = "Error: No contiene .";
            }
            else if (email.Substring(posP).Length < 3 || email.Substring(posP).Length > 4)
            {
                this.lblVerificacion.Text = "Error: No tiene un dominio mayor que 2 y menor de 3";
            }
            else if (email.IndexOf("@") > email.IndexOf("."))
            {
                this.lblVerificacion.Text = "Error: No puede tener un punto antes que un @";
            }
            else if (email.Count(c => c == '@') > 1)
            {
                this.lblVerificacion.Text = "Error: No puede tener dos @";
            }
            else
            {
                this.lblVerificacion.Text = "Verificacion Con exito";
                this.lblVerificacion.ForeColor = Color.Green;
            }
        }
    }
}
