using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchivoDeTexto1
{
    class Persona
    {
        private string nombre;
        private double edad;

        public double Edad 
        {
            get 
            { 
                return edad; 
            }
            set 
            { 
                edad = value; 
            }
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public Persona()
        {
            Nombre = "";
            Edad = 0;
        }
        public override string ToString()
        {
            return nombre + "-" + edad;
        }
    }
}
