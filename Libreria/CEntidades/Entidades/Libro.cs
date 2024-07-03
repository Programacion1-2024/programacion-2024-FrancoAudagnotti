namespace CEntidades.Entidades
{
    public class Libro
    {
        public int IdLibro { get; set; }

        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string AnioPublicacion { get; set; }
        public float PrecioVenta { get; set; }
        
        public Editorial Editorial { get; set; }
        
        public ICollection<Autor> Autores { get;}
        public ICollection<Genero> Generos { get;}
        public ICollection<Copia> Copias { get;}
        public ICollection<Venta> Ventas { get;}
    }
}
