using Microsoft.EntityFrameworkCore;

namespace MigrateDatabase
{
    public class CustomerMap : IEntityTypeConfiguration<Costumer>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Costumer> builder)
        {
            builder.ToTable("Customer", "dbo");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Username).HasColumnName("Username").IsRequired(false).IsUnicode(false);

            builder.Property(x => x.Email).HasColumnName("Email").IsRequired(false).IsUnicode(false);

            builder.Property(x => x.CustomerGuid).HasColumnName("CustomerGuid").HasColumnType("uniqueidentifier").IsRequired(true);

            builder.Property(x => x.IsTaxExempt).HasColumnName("IsTaxExempt").HasColumnType("bit").IsRequired(true);

            builder.Property(x => x.AffiliateId).HasColumnName("AffiliateId").HasColumnType("bit").IsRequired(true);
        }
    }
}