using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.Entidades
{
    public class Genero
    {
        public int IdGenero { get; set; }
        public string DescripcionGenero { get; set; }

        public ICollection<Libro> Libros { get; }
    }
}
