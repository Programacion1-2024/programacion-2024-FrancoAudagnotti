using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.Entidades
{
    public class Editorial
    {
        public int IdEditorial { get; set; }
        public string DireccionEditorial { get; set; }
        public string ContactoEditorial { get; set; }
        public ICollection<Libro> Libros { get; set; }
    }
}
