namespace Stock.DAL
{
    public class DbContext
    {
        public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base()
            {
            }
        }
    }
}