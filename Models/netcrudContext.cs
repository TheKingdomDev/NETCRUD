using Microsoft.EntityFrameworkCore;

namespace NetCrud.Models
{
    public class NetCrudContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<NetCrudContext> options)
            : base(options)
        {
        }

        public DbSet<netcrud.Models.Snippet> Snippet { get; set; }
    }
}