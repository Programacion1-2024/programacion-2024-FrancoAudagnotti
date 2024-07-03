using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.Entidades
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public DateTime Antiguedad { get; set; }
        public string Cargo { get; set; }
        public double Sueldo { get; set; }

        public Persona Persona { get; set; }

        public ICollection<Venta> Ventas { get; set; }
        public ICollection<Prestamo> Prestamos { get; set; }
    }
}
