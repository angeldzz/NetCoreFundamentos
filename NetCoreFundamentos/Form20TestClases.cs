using Microsoft.VisualBasic.ApplicationServices;
using ProyectoClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace NetCoreFundamentos
{
    public partial class Form20TestClases : Form
    {
        public Form20TestClases()
        {
            InitializeComponent();
        }

        private void btnCrearPersona_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Nombre = "Angel";
            persona.Apellidos = "Pinto";
            persona.Edad = 25;
            persona.Genero = TipoGenero.Femenino;
            persona.Nacionalidad = Paises.España;
            //Es obligatorio instanciar la clase domicilio para usarla, pero la podemos instanciar en Persona
            persona.Domicilio = new Direccion();

            persona.Domicilio.Calle = "Avenida Enero";
            persona.Domicilio.Ciudad = "Madrid";
            persona.Domicilio.CodigoPostal = 28044;
            persona[0] = "Vamos 1";
            persona[1] = "Vamos 2";
            this.lstClases.Items.Add(persona[0] + " " + persona[1]);
            this.lstClases.Items.Add($"Nombre: {persona.Nombre}, Apellido: {persona.Apellidos}, Edad: {persona.Edad}, " +
                $"Genero {persona.Genero} Nacionalidad {persona.Nacionalidad}");

            this.lstClases.Items.Add($"Direccion: {persona.Domicilio.Calle} , {persona.Domicilio.Ciudad} , {persona.Domicilio.CodigoPostal}");

            this.lstClases.Items.Add("Nombre de distinta forma" + persona.GetNombreCompleto(4));
        }

        private void btnCrearEmpleado_Click(object sender, EventArgs e)
        {
            //Como actualmente tenemos dos constructores en cada uno, podemos usar el vacio o el de 2 parametros
            //Empleado emp = new Empleado(); 
            Empleado emp = new Empleado();
            emp.Nombre = "Becario";
            emp.Apellidos = "Becario";
            this.lstClases.Items.Add($"Empleado: {emp.GetNombreCompleto()}");
            this.lstClases.Items.Add($"Salario: {emp.GetSalarioMinimo()}$");
            this.lstClases.Items.Add($"Vacaciones: {emp.GetDiasVacaciones()}");
            Director dir = new Director();
            dir.Nombre = "Director";
            dir.Apellidos = "Director";
            this.lstClases.Items.Add($"Director: {dir.GetNombreCompleto()}");
            this.lstClases.Items.Add($"Salario: {dir.GetSalarioMinimo()}$");
            this.lstClases.Items.Add($"Vacaciones: {dir.GetDiasVacaciones()}");

        }
    }
}
