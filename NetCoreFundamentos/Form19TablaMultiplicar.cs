using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form19TablaMultiplicar : Form
    {
        List<TextBox> resultados;
        List<Button> botones;
        public Form19TablaMultiplicar()
        {
            InitializeComponent();
            resultados  = new List<TextBox>();
            botones = new List<Button>();
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    botones.Add((Button)control);
                    control.Click += TablaMultiplicar;
                }else if (control is TextBox)
                {
                    resultados.Add((TextBox)control);
                }
            }
            resultados.Reverse();
        }

        private void TablaMultiplicar(object? sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int num = int.Parse(btn.Text);
            for (int i = 0; i < this.resultados.Count; i++)
            {
                this.resultados[i].Text = (num * (i + 1)).ToString();
            }
        }
    }
}
