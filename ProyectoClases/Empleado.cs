using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProyectoClases
{
    public class Empleado : Persona
    {
        protected int SalarioMinimo { get; set; }
        public Empleado()
        {
            Debug.WriteLine("Constructor Empleado vacio");
            this.SalarioMinimo = 1800;
        }

        public Empleado(string nombre, string apellido) : base("Empleado", "EmpApellido")
        {
            this.Nombre = nombre;
            this.Apellidos = apellido;
            Debug.WriteLine("Constructor empleado con dos parametros");
        }
        public int GetSalarioMinimo()
        {
            return this.SalarioMinimo;
        }
        public virtual int GetDiasVacaciones()
        {
            Debug.WriteLine("GetVacaciones() Empleado");
            return 22;
        }
    }
}
