using MagicVilla_API.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_API.Data
{
    public class DataContext: DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options)//ctor tabulador
     : base(options)
        {
        }
        public DbSet<Villa> Villas{ get; set; }
    }
}
