using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form17SumarBotones : Form
    {
        List<Button> botones;
        public Form17SumarBotones()
        {
            InitializeComponent();
            this.botones = new List<Button>();
            // Recorremos todos los botones dentro del panel
            //como solo he dibujado botones, hacemos la abstraccion a button
            foreach (Button boton in this.panel1.Controls)
            {
                this.botones.Add(boton);
                boton.Click += SumarNumeros;//le asignamos funcionalidad a cada boton
            }
        }

        private void SumarNumeros(object? sender, EventArgs e)
        {
            Button botonPulsado = (Button)sender;
            int numero = int.Parse(botonPulsado.Text);
            int suma = int.Parse(this.txtSuma.Text);
            suma += numero;
            this.txtSuma.Text = suma.ToString();

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            //hacemos un for each a cada boton del panel y asginamos valor aleatorio
            foreach (Button btn in this.botones)
            {
                int aleat = random.Next(1,50);
                btn.Text = aleat.ToString();

            }
        }
    }
}
