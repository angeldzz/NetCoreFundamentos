using ProyectoClases.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
namespace NetCoreFundamentos
{
    public partial class Form24ColeccionMascotaXML : Form
    {
        XmlSerializer serializer;
        ColeccionMascotas mascotasList;
        public Form24ColeccionMascotaXML()
        {
            InitializeComponent();
            this.serializer = new XmlSerializer(typeof(ColeccionMascotas));
            this.mascotasList = new ColeccionMascotas();
        }

        public void DibujarMascotas()
        {
            this.lstMascotas.Items.Clear();
            foreach (Mascota mascota in mascotasList)
            {
                this.lstMascotas.Items.Add(mascota.Nombre);
            }
        }
        private void btnNuevaMascota_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Nombre = this.txtNombre.Text;
            mascota.Raza = this.txtRaza.Text;
            mascota.Edad = int.Parse(this.txtEdad.Text);
            this.mascotasList.Add(mascota);
            this.DibujarMascotas();
            this.txtNombre.Text = "";
            this.txtRaza.Text = "";
            this.txtEdad.Text = "";
        }

        private void btnLeerMascotas_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader("ListaMascotas.xml"))
            {
                this.mascotasList = (ColeccionMascotas)this.serializer.Deserialize(reader);
                this.DibujarMascotas();
            }
        }

        private void btnGuardarMascotas_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("ListaMascotas.xml"))
            {
                this.serializer.Serialize(writer, this.mascotasList);
                writer.FlushAsync();
                this.lstMascotas.Items.Clear();
                this.mascotasList.Clear();
            }
        }

        private void lstMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.lstMascotas.SelectedIndex;
            if (index != -1)
            {
                Mascota mascota = this.mascotasList[index];
                this.txtNombre.Text = mascota.Nombre;
                this.txtRaza.Text = mascota.Raza;
                this.txtEdad.Text = mascota.Edad.ToString();
            }
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            //Abrir el OpenFile para seleccionar la imagen
            this.openFileDialog1.ShowDialog();
            //Recuperamos la ruta de la imagen
            string path = this.openFileDialog1.FileName;
            //Dibujamos la imagen en el Form
            this.pictureBox1.Image = Image.FromFile(path);
        }
    }
}
