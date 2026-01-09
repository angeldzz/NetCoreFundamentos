using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ProyectoClases.Helpers;
namespace NetCoreFundamentos
{
    public partial class Form21Files : Form
    {
        public string Path { get; set; }
        HelperFiles helper;
        public Form21Files()
        {
            InitializeComponent();
            //CUANDO HABLAMOS DE RUTAS O CARACTERES ESPECIALES DENTRO DE STRING
            //TENEMOS DOS FORMAS DE ESCRIBIR DICHOS CARACTERES
            // 1) C:\carpeta\1.
            // //this.Path = "C:\carpeta\1"
            // 2) Utilizar @ antes del string fuera del mismo
            // this.Path = @"C:\carpeta\1"
            this.Path = "file1.txt";
            this.helper = new HelperFiles();
        }

        private void bnNuevoNombre_Click(object sender, EventArgs e)
        {
            this.lstNombres.Items.Add(this.txtNombre.Text);

        }
        private async void btnWriteFile_Click(object sender, EventArgs e)
        {
            ////Tenemos una clase llamada fileInfo que nos devuelve un file y podemos generar
            //// un writer o un reader
            //FileInfo file = new FileInfo(this.Path);
            ////Creamos el fichero
            //using (TextWriter writer = file.CreateText())
            //{
            //    string content = this.GetNombresListBox();
            //    await writer.WriteAsync(content);
            //    //Despues de escribir en cualquier fichero debemos liberar la memoria
            //    await writer.FlushAsync();
            //    writer.Close();
            //    MessageBox.Show("Fichero Almacenado");

            //}
            string content = this.GetNombresListBox();
            await this.helper.WriteFileAsync(this.Path, content);
            MessageBox.Show("Fichero Almacenado");
        }
        public string GetNombresListBox()
        {
            string data = "";
            foreach(string nombre in this.lstNombres.Items)
            {
                data += nombre + ",";
            }
            data = data.Trim(',');
            return data;
        }
        private async void btnLeerFile_Click(object sender, EventArgs e)
        {
            //FileInfo file = new FileInfo(this.Path);
            //using (TextReader reader = file.OpenText())
            //{
            //    string content = await reader.ReadToEndAsync();
            //    reader.Close();
            //    txtContenidoFile.Text = content;
            //}
            string content = await this.helper.ReadFileAsync(this.Path);
            this.txtContenidoFile.Text = content;
            string[] nombres = content.Split(',');
            foreach (string name in nombres)
            {
                this.lstNombres.Items.Add(name);
            }
        }

        
    }
}
