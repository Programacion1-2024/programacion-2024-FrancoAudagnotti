using CDatos.Repositories.Contracts;
using CEntidades.Entidades;
using CLogica.Contracts;

namespace CLogica.Implementations
{
    public class AutorLogic : IAutorLogic
    {
        private IAutorRepository _autorRepository;

        public AutorLogic(IAutorRepository autorRepository)
        {
            _autorRepository = autorRepository;
        }

        public void CrearAutor(Autor autor) // creo el autor en el repo (bdd)
        {
            _autorRepository.Create(autor);
            _autorRepository.Save();
        }
        public void ModificarAutor(string documentoAutor, Autor autor)
        {
            Autor? autorExistente = _autorRepository.FindByCondition(a => a.Persona != null && a.Persona.Documento != null && a.Persona.Documento == documentoAutor).FirstOrDefault();
            if (autorExistente == null)
                throw new ArgumentException("Autor no encontrado");

            autorExistente.Biografia = autor.Biografia;
            autorExistente.FechaNacimiento = autor.FechaNacimiento;

            _autorRepository.Update(autorExistente);
            _autorRepository.Save();
        }
        public void EliminarAutor(string documentoAutor)
        {
            Autor? autor = _autorRepository.FindByCondition(a => a.Persona != null && a.Persona.Documento != null && a.Persona.Documento == documentoAutor).FirstOrDefault();
            if (autor == null)
                throw new ArgumentException("Autor no encontrado");

            _autorRepository.Delete(autor);
            _autorRepository.Save();
        }
        public Autor ObtenerAutor(string documentoAutor)
        {
            {
                Autor? autor = _autorRepository.FindByCondition(a => a.Persona != null && a.Persona.Documento != null && a.Persona.Documento == documentoAutor).FirstOrDefault();
                if (autor == null)
                    throw new ArgumentException("Autor no encontrado");

                return autor;
            }
        }

    }
}