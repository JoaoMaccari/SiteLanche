using SiteLanche.Context;
using SiteLanche.Models;
using SiteLanche.Repositories.Interfaces;

namespace SiteLanche.Repositories {
    public class CategoriaRepository : ICategoriaRepository {

        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context) {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;

    }
}
