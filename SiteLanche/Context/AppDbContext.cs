using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using SiteLanche.Models;

namespace SiteLanche.Context {

    public class AppDbContext : DbContext {

        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options) 
        {
        }

        public DbSet<Categoria> Categorias { get; set; }    


        public DbSet<Lanche> Lanches { get; set; }  

        public DbSet<CarrinhoCompraItem> CarrinhoCompraItems { get; set; }
        public object CarrinhoCompraItens { get; internal set; }
    }
}
