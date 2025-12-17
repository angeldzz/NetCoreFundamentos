using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form15ArrayList : Form
    {
        public Form15ArrayList()
        {
            InitializeComponent();
            //Creamos una coleccion generica
            List<Button> botones = new List<Button>();
            //Detecta automaticamente los elementos
            botones.Add(this.button1);
            botones.Add(this.button2);
            botones.Add(this.button3);
            //nos da error si hacemos: botones.Add(this.textBox1);


            //Vamos a crear una coleccion no tipada
            ArrayList coleccion = new ArrayList();
            coleccion.Add(this.button1);
            coleccion.Add(this.button2);
            coleccion.Add(this.button3);

            //Si deseamos acceder a un objeto y modificar alguna caracteristica
            //necesitamos realizar casting

            ((Button)coleccion[0]).BackColor = Color.Yellow;
            coleccion.Add(this.textBox1);
            //Podemos realizar casting con foreach
            foreach (Control boton in coleccion)
            {
                boton.BackColor = Color.LightBlue;
                //Cuando tenemos multiples objetos de diferentes clases,
                //nos podemos abstraer en el recorrido, pero a lo mejor
                //necesitamos alguna caracteristica especial de cada uno,
                //una caja tiene un metodo llamado Parte()
                if (boton is TextBox)
                {
                    ((TextBox)boton).Paste();
                }
            }
            this.button1.Click += MetodoDelegado;
        }
        //Creamos un mtodo delegado
        void MetodoDelegado(object sender, EventArgs e)
        {

        }
    }
}
