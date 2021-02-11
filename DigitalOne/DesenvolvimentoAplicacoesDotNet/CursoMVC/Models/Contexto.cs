using Microsoft.EntityFrameworkCore;

namespace CursoMVC.Models
{
    public class Contexto : DbContext

    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Cursomvc;Integrated Security=True");
            //optionsBuilder.UseMySql(@"Server=localhost;Database=cursomvc;Uid=root;Pwd=1234;");
        }
    }
}
