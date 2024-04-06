using covid19.web.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace covid19.web.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> op): base(op)  
        {  
        }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<CoronaֹVaccine> CoronaֹVaccine { get; set; }

    }
}
