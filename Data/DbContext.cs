namespace DemoMinimal.API.Data
{
    public class DbContext
    {
        private DbContextOptions<MinimalContextDb> options;

        public DbContext(DbContextOptions<MinimalContextDb> options)
        {
            this.options = options;
        }
    }
}