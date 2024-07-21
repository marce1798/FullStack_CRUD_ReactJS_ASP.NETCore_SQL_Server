using API_DbManagers.Models;
using Microsoft.EntityFrameworkCore;

namespace API_DbManagers.Context
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}

        public DbSet<Db_Manager> Db_Manager { get; set; }
    }
}
