using CEntidades.Entidades;

namespace CLogica.Contracts
{
    public interface IExampleLogic
    {
        Task<List<Libro>> GetAll();
    }
}
