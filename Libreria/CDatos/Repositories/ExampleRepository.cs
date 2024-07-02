using CDatos.Contexts;
using CDatos.Repositories.Contracts;
using CEntidades.Entidades;
using Microsoft.EntityFrameworkCore;

namespace CDatos.Repositories
{
    public class ExampleRepository : Repository<Libro>, IExampleRepository
    {

        public ExampleRepository(LibreriaContext context) : base(context)
        {
            
        }

        public async Task<List<Libro>> GetAll()
        {
            try
            {
                return await _context.Libro.ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

      
    }
}
