namespace CEntidades.Entidades
{
    public class Libro
    {
        public int IdLibro { get; set; }

        public string ISBN { get; set; }
        public string TituloLibro { get; set; }
        public string DescripcionLibro { get; set; }
        public string AnioPublicacionLibro { get; set; }
        public float PrecioVentaLibro { get; set; }
        
        
        public ICollection<Autor> Autores { get;}
        public ICollection<Genero> Generos { get;}
        public ICollection<Copia> Copias { get;}
        public Editorial Editorial { get; set; }
    }
}
