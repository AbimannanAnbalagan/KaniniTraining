using Microsoft.EntityFrameworkCore;
using Rel2.Models;

namespace Rel2.Data
{
    public class CompanyCFContext: DbContext
    {
        public CompanyCFContext(DbContextOptions<CompanyCFContext> options): base(options)
        {
            
        }

        public DbSet<Dept> Depts { get; set; }

        public DbSet<Emp> Emps { get; set; }

        public DbSet<EmpDetails> EmpDetails { get; set; }   
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
