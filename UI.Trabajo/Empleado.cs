using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Trabajo
{
    public class Empleado
    {
        private int numero;
        private string nombre;
        private DateTime fechaNacimiento;
        private string sexo;
        private char grupo;
        private double sueldo;
        private bool seguroMedico;
       
        public int Numero{get=>numero;set=>numero=value;}
        public string Nombre{get=>nombre;set=>nombre=value;}
        public DateTime FechaNacimiento{get=>fechaNacimiento;set=>fechaNacimiento=value;}
        public string Sexo{get=>sexo;set=>sexo=value;}
        public char Grupo{get=>grupo;set=>grupo=value;}
        public double Sueldo{get=>sueldo;set=>sueldo=value;}
        public bool SeguroMedico{get=>seguroMedico;set=>seguroMedico=value;}

      
        public override string ToString()
        {
            return $"Empleado #{Numero}, Nombre:{Nombre}, Nacimiento:{FechaNacimiento.ToShortDateString()}, " +
                   $"Sexo:{Sexo}, Grupo:{Grupo}, Sueldo:{Sueldo}, Seguro:{SeguroMedico}";
        }




    }
}
