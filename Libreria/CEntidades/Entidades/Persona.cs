using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CEntidades.Entidades
{
    public class Persona
    {
        public int IdPersona { get; set; }  
        public long DNIPersona { get; set; }
        public string NombrePersona { get; set; }
        public string ApellidoPersona { get; set;}
        public string NacionalidadPersona { get; set; }
        public string TelefonoPersona { get; set; }
        public Autor? Autor { get; set; }
        public Cliente? Cliente { get; set; }
        public Empleado? Empleado { get; set; }
    }
}
