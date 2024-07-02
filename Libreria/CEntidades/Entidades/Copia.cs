using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.Entidades
{
    public class Copia
    {
        public int IdCopia { get; set; }
        public int CantidadCopia { get; set; }
        public double PrecioCopia { get; set; }

        public Libro Libro { get; set; }
        public ICollection<Prestamo> Prestamos { get; set; }
    }
}
