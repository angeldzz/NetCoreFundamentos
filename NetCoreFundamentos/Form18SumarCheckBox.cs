using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form18SumarCheckBox : Form
    {
        List<CheckBox> botones;
        public Form18SumarCheckBox()
        {
            InitializeComponent();
            botones = new List<CheckBox>();
            foreach (CheckBox btn in this.panel1.Controls)
            {
                botones.Add(btn);
                btn.Click += SumarNumeros;
            }
        }

        private void SumarNumeros(object? sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            int suma = int.Parse(txtSuma.Text);
            if (chk.Checked)
            {
                suma += int.Parse(chk.Text);
            }
            else
            {
                suma -= int.Parse(chk.Text);
            }
            txtSuma.Text = suma.ToString();
        }

        private void btnIniciarApp_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            foreach (CheckBox btn in botones)
            {
                int aleat = random.Next(1,50);
                btn.Text = aleat.ToString();
            }
        }
    }
}
