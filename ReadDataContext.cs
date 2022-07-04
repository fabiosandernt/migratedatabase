using Microsoft.EntityFrameworkCore;

namespace MigrateDatabase
{
    public class ReadDataContext : DbContext
    {
        public ReadDataContext(DbContextOptions<ReadDataContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.ApplyConfiguration(new CustomerMap());

            base.OnModelCreating(modelBuilder);
        }
        public static ReadDataContext Initiate()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ReadDataContext>();
            optionsBuilder.UseSqlServer("Data Source=BYCLOUD\\SQLEXPRESS;Initial Catalog=sigosta;Integrated Security=True;Persist Security Info=False");
            return new ReadDataContext(optionsBuilder.Options);
        }

        public DbSet<Costumer> Costumers{get ; set;}

    }
}