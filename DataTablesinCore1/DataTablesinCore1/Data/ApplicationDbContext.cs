using DataTablesinCore1.Models;
using Microsoft.EntityFrameworkCore;

namespace DataTablesinCore1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
                    
        }
        public virtual DbSet<tblBananaStock> TblBananaStock { get; set; }
    }
}
