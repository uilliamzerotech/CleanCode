using Microsoft.EntityFrameworkCore;
using Model.Entity;

namespace Model.Context
{
    public class DataBaseContext:DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Livro> Livro { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<PedidoLivro> PedidoLivro { get; set; }
        public DataBaseContext(DbContextOptions<DataBaseContext> opt):base(opt)
        {
            
        }
    }
}
