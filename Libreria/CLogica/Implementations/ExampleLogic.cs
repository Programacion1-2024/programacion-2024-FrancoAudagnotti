using CDatos.Repositories.Contracts;
using CEntidades.Entidades;
using CLogica.Contracts;

namespace CLogica.Implementations
{
    public class ExampleLogic : IExampleLogic
    {
        private IExampleRepository _exampleRepository;

        public ExampleLogic(IExampleRepository exampleRepository)
        {
            _exampleRepository = exampleRepository;
        }

        public async Task<List<Libro>> GetAll()
        {
            return await _exampleRepository.GetAll();
        }
    }
}
