using Microsoft.EntityFrameworkCore;

namespace MigrateDatabase
{
    public class WriteDataContext : DbContext
    {
      
        public WriteDataContext(DbContextOptions<WriteDataContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.ApplyConfiguration(new CustomerMap());

            base.OnModelCreating(modelBuilder);
        }
        public static WriteDataContext Initiate()
        {
            var optionsBuilder = new DbContextOptionsBuilder<WriteDataContext>();
            optionsBuilder.UseSqlServer("Data Source=BYCLOUD\\SQLEXPRESS;Initial Catalog=nop450_3;Integrated Security=True;Persist Security Info=False");
            return new WriteDataContext(optionsBuilder.Options);
        }
        public DbSet<Costumer> Costumers{get ; set;}

    }
}