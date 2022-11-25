using SiteLanche.Models;

namespace SiteLanche.Repositories.Interfaces {
    public interface ICategoriaRepository {

        IEnumerable<Categoria> Categorias { get; }  
    }
}
