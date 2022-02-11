
using api_productos.Model;
using Microsoft.EntityFrameworkCore;

namespace api_productos.Domain
{
    public class MySqlContext:DbContext
    {


        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {

        }


        public virtual DbSet<Producto> Productos { get; set; }

    }
}
