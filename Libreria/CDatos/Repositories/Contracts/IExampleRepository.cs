

using CEntidades.Entidades;

namespace CDatos.Repositories.Contracts
{
    public interface IExampleRepository : IRepository<Libro>
    {
        Task<List<Libro>> GetAll();

    }
}
