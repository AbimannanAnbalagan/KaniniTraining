using Microsoft.EntityFrameworkCore;
using Relation2.Models;

namespace Relation2
{
    public class CompanyContextCF : DbContext
    {
        public CompanyContextCF(DbContextOptions<CompanyContextCF> options) : base(options) 
        {

        }
        public DbSet<Dept> Dept { get; set; }
        public DbSet<Emp> Emp { get; set; }

    }
}
