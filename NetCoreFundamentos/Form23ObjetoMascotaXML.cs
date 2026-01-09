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
    public partial class Form23ObjetoMascotaXML : Form
    {
        XmlSerializer serializer;
        public Form23ObjetoMascotaXML()
        {
            InitializeComponent();
            this.serializer = new XmlSerializer(typeof(Mascota));
        }
        private async void btnGuardarClase_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Nombre = this.txtNombre.Text;
            mascota.Raza = this.txtRaza.Text;
            mascota.Edad = int.Parse(this.txtEdad.Text);

            //Asignar la imagen en Base64 si existe
            if (this.pictureBox1.Tag != null)
            {
                mascota.ImagenBinary = this.pictureBox1.Tag.ToString();
            }

            //Las clases que se utilizan son de tipo STREAM
            //Para escribir SteamWriter, StreamReader
            using (StreamWriter writer = new StreamWriter("mascota.xml"))
            {
                this.serializer.Serialize(writer, mascota);
                await writer.FlushAsync();
                writer.Close();
            }
            this.txtNombre.Text = "";
            this.txtRaza.Text = "";
            this.txtEdad.Text = "";
            this.pictureBox1.Image = null;
            this.pictureBox1.Tag = null;
        }

        private void btnLeerClase_Click(object sender, EventArgs e)
        {
            Mascota mascota = null;
            using (StreamReader reader = new StreamReader("mascota.xml"))
            {
                mascota = (Mascota)this.serializer.Deserialize(reader);
                this.txtNombre.Text = mascota.Nombre;
                this.txtRaza.Text = mascota.Raza;
                this.txtEdad.Text = mascota.Edad.ToString();
                
                //Recuperar y mostrar la imagen
                if (!string.IsNullOrEmpty(mascota.ImagenBinary))
                {
                    byte[] imageBytes = Convert.FromBase64String(mascota.ImagenBinary);
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        this.pictureBox1.Image = Image.FromStream(ms);
                    }
                    //Guardar el Base64 en el Tag para poder volver a guardar
                    this.pictureBox1.Tag = mascota.ImagenBinary;
                }
            }
        }

        private void btnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            //Abrir el OpenFile para seleccionar la imagen
            this.openFileDialog1.ShowDialog();
            //Recuperamos la ruta de la imagen
            string path = this.openFileDialog1.FileName;
            //Dibujamos la imagen en el Form
            this.pictureBox1.Image = Image.FromFile(path);
            //Convertir la imagen a bytes
            byte[] imageBytes = File.ReadAllBytes(path);
            //Guardar los bytes en formato Base64 para XML
            this.pictureBox1.Tag = Convert.ToBase64String(imageBytes);

        }
    }
}
