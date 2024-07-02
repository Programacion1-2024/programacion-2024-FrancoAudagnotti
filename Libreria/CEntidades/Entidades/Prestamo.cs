using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.Entidades
{
    public class Prestamo
    {
        public int IdPrestamo { get; set; }

        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public DateTime FechaDevolucion { get; set; }

        public Cliente Cliente { get; set; }
        public Copia Copia { get; set; }
        public FormaPago FormaPago { get; set; }
    }
}
