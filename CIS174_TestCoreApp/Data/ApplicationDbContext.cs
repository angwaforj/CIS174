using Microsoft.EntityFrameworkCore;

namespace CIS174_TestCoreApp.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
      
        public DbSet<Person> Persons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(@"Server=tcp:jackson-angwafor.database.windows.net,1433;Initial Catalog=CIS174Spring2019;User ID=jnangwafor;Password=Laurice@1929;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
    }
}
