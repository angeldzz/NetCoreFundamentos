using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace NetCoreFundamentos
{
    public partial class Form08StringBuilder : Form
    {
        public Form08StringBuilder()
        {
            InitializeComponent();
        }

        private void btnInvertirstring_Click(object sender, EventArgs e)
        {
            Stopwatch krono = new Stopwatch();
            string cadena = this.txtStringBuilder.Text;
            int longitud = cadena.Length;
            // Comenzamos el proceso
            krono.Start();
            for (int i = 0; i < longitud; i++)
            {
                //Siempre Recuperamos la ultima letra
                char letra = cadena[longitud - 1];
                // Eliminamos la ultima letra
                cadena = cadena.Remove(longitud - 1, 1);
                //Invertimos la letra en la posicion i del bucle
                cadena = cadena.Insert(i, letra.ToString());
            }
            //Finalizamoe el proceso
            krono.Stop();
            // El objeto Stopwatch Contiene una serie de propiedades
            // para comprobar el tiempo entre el proceso
            this.lblTiempo.Text = $"Segundos= {krono.Elapsed.Seconds}, Milisegundos= {krono.Elapsed.Milliseconds}";
            this.txtStringBuilder.Text = cadena;
        }

        private void btnInvertirStringBuilder_Click(object sender, EventArgs e)
        {
            Stopwatch krono = new Stopwatch();
            //Usamos la clase String Builder
            StringBuilder cadena = new StringBuilder();// o asi (this.txtStringBuilder.Text);
            // para añadir contenido tiene un metodo llamado append
            cadena.Append(this.txtStringBuilder.Text);
            //cogemos la longitud de la cadena
            int longitud = cadena.Length;
            // Comenzamos el proceso
            krono.Start();
            for (int i = 0; i < longitud; i++)
            {
                //Siempre Recuperamos la ultima letra
                char letra = cadena[longitud - 1];
                // Eliminamos la ultima letra
                cadena = cadena.Remove(longitud - 1, 1);
                //Invertimos la letra en la posicion i del bucle
                cadena = cadena.Insert(i, letra.ToString());
            }
            //Finalizamoe el proceso
            krono.Stop();
            // El objeto Stopwatch Contiene una serie de propiedades
            // para comprobar el tiempo entre el proceso
            this.lblTiempo.Text = $"Segundos= {krono.Elapsed.Seconds}, Milisegundos= {krono.Elapsed.Milliseconds}";
            this.txtStringBuilder.Text = cadena.ToString();
        }
    }
}
