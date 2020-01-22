using LocFut.Domain;
using Microsoft.EntityFrameworkCore;

namespace LocFut.Data.Context
{
    public class DbContextLocFut : DbContext
    {
        public DbSet<Quadra> Quadra { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Password=sa123456;Persist Security Info=True;User ID=sa;Initial Catalog=LocaFutt;Data Source=DESKTOP-UDCRAL0");
        }
    }
}
