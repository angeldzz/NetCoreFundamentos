using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProyectoClases
{
    public enum TipoGenero { Masculino = 0, Femenino = 1}
    public enum Paises { España, Francia, Alemania, Andorra,Colombia }
    public class Persona
    {
        //Constructor para instanciar domicilio
        public Persona()
        {
            Debug.WriteLine("Constructor persona vacio");
        }
        public Persona(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellidos = apellido;
            Debug.WriteLine("Constructor persona con dos parametros");
        }
        //Comentario que permite cerrar partes de codigo
        #region Propiedades
        public Direccion Domicilio { get; set; }
        public Direccion DomicilioVacaciones { get; set; }
        public TipoGenero _Genero;
        public TipoGenero Genero { get {
                return this._Genero;
            }
            set {
                if (value != TipoGenero.Femenino && value != TipoGenero.Masculino)
                {
                    throw new Exception("El genero no puede ser ese");
                }
                else
                {
                    this._Genero = value;
                }
            }
        }
        public Paises Nacionalidad { get; set; }
        public string Nombre { get; set; }// propiedades autoimplementadas
        public string Apellidos { get; set; }
        //Campo de propiedad
        private int _Edad;
        public int Edad {
            // devemos devolver siempre el campo propiedad por que es el que cambiamos
            get { return this._Edad; }
            set {
                if (value >= 0)
                {
                    //se deben usar campos de propiedad para no entrar en bucles infinitos
                    this._Edad = value;
                }
                else
                {
                    // podemos lanzar una excepcion
                    throw new Exception("La edad no puede ser negativa");
                }
            }
        }
        #endregion
        //Propiedades Indizadas
        private string _DescripcionThis;
        public string this[int indice]
        {
            get { return this._DescripcionThis; }
            set
            {
                //Devolvemos una descripcion aleatoria de nuestro numero
                Random random = new Random();
                int dato = random.Next(1,30);
                this._DescripcionThis = "Descricion: " + dato;
            }
        }
        // Metodos simples separados
        // Polimorfismo para tener un solo nombre
        #region Metodos
        public string GetNombreCompleto()
        {
            return this.Nombre + " " + this.Apellidos;
        }
        public string GetNombreCompleto(bool orden)
        {
            return this.Apellidos + " " + this.Nombre;
        }
        public string GetNombreCompleto(int num1)
        {
            return (this.Nombre + " " + this.Apellidos).ToUpper();
        }
        public string GetNombreCompleto(int num1, int num2)
        {
            return (this.Nombre + " " + this.Apellidos).ToLower();
        }
         
        #endregion
    }
}
