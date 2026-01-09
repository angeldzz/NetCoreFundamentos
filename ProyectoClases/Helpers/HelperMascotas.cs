using ProyectoClases.Models;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Text;

namespace ProyectoClases.Helpers
{
    public class HelperMascotas
    {
        public List<Mascota> Mascotas { get; set; }
        //Queremos almacenar de forma fisicia las mascotas en files
        private HelperFiles helper;
        private string path;
        public HelperMascotas()
        {
            this.Mascotas = new List<Mascota>();
            this.helper = new HelperFiles();
            this.path = "mascota.txt";
        }
        // El programador escriba write y guardamos las mascotas
        // El programador escriba read y leamos un string y rellenamos la coleccion
        private void ConvertirMascotasList(string data)
        {
            //Garfield,Gato@Pluto,Perro
            this.Mascotas.Clear();
            //Separamos cada mascota
            string[] datosmascota = data.Split('@');
            foreach (var stringmascota in datosmascota)
            {
                //Separamos las propiedades
                string[] propiedades = stringmascota.Split(',');
                //Convertirmos el string en objetos
                Mascota mascota = new Mascota();
                mascota.Nombre = propiedades[0];
                mascota.Raza = propiedades[1];
                this.Mascotas.Add(mascota);
            }
        }
        public async Task ReadMascotaAsync()
        {
            //Leemos el fichero de masocta
            string data = await this.helper.ReadFileAsync(this.path);
            this.ConvertirMascotasList(data);
        }
        //Convertimos la coleccion a string
        private string ConvertirMascotasString()
        {
            string data = "";
            foreach (Mascota mascota in this.Mascotas)
            {
                //Separamos las propiedades mediante coma
                string propiedades = mascota.Nombre + "," + mascota.Raza;
                //Separamos cada objetos string de mascota
                data += propiedades + "@";
            }
            data = data.TrimEnd('@');
            return data;
        }
        public async Task WriteMascotasAsync()
        {
            //Convertimos la coleccion a string
            string data = this.ConvertirMascotasString();
            //escribimos los datos en file
            await this.helper.WriteFileAsync(this.path,data);
        }
    }
}
