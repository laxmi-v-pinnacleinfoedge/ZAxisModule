using Microsoft.EntityFrameworkCore;
using ZAxisModule.Models;

namespace ZAxisModule.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
        public DbSet<EMPLOYEE> Employee { get; set; }
        public DbSet<USER_MASTER_NW> UserMasterNw { get; set; }
        public DbSet<ZBA_MASTER> ZbaMaster { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EMPLOYEE>().ToTable("EMPLOYEES", schema: "TT").HasNoKey();
            modelBuilder.Entity<USER_MASTER_NW>().ToTable("USER_MASTER_NW", schema: "TT");
            modelBuilder.Entity<ZBA_MASTER>().ToTable("ZBA_MASTER", schema: "PHASEZERO");
        }
    }
}
