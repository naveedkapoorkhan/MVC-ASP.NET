namespace CRUD_APP_STUDENT.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContect(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }

    }

}
