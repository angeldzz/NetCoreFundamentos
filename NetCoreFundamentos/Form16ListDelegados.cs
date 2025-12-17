using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form16ListDelegados : Form
    {
        int contador;
        public Form16ListDelegados()
        {
            InitializeComponent();
            //Inicializamos la variable contador
            this.contador = 0;
            //cremos una coleccion de botones y añadimos todos los botones
            List<Button> botones = new List<Button>();
            //botones.Add(this.button1);
            //botones.Add(this.button2);
            //botones.Add(this.button3);
            //botones.Add(this.button4);
            //botones.Add(this.button5);
            //botones.Add(this.button6);
            //Podemos añadir dinamicamente todos los botones a control
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    botones.Add((Button)control);
                }
            }
            //Vamos a crear un metodo para que todos los botones lean al ser pulsados
            foreach (Button boton in botones)
            {
                boton.Click += PulsarBoton;
            }
        }

        private void PulsarBoton(object? sender, EventArgs e)
        {
            this.contador++;
            this.txtContador.Text = this.contador.ToString();
            // Queremos acceder al objeto que ha realizado la peticion
            // al metodo. mediante sender se captura dicho objeto
            ((Button)sender).BackColor = Color.LightBlue;
        }
    }
}
