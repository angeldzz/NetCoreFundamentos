using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProyectoClases
{
    public class Director: Empleado
    {
        public Director()
        {
            Debug.WriteLine("Constructor Director vacio");
            this.SalarioMinimo = this.SalarioMinimo + 200;
        }
        public override int GetDiasVacaciones()
        {
            int vacasEmpleado = base.GetDiasVacaciones();
            Debug.WriteLine("GetVacaciones() Director");
            return vacasEmpleado + 8;
        }
    }
}
