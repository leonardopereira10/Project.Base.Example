using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Base.Example.Domain.Objects;

namespace Project.Base.Example.Repository
{
    internal class CityMap : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            _ = builder.ToTable("CITIES");
            #region ID
            _ = builder.HasKey(x => x.Id);
            _ = builder.Property(x => x.Id)
                 .HasColumnName("ID")
                 .HasColumnType("UNIQUEIDENTIFIER")
                 .IsRequired();
            _ = builder.HasIndex(x => x.Id)
                 .HasDatabaseName("IDX_CITY")
                 .IsUnique();
            #endregion

            _ = builder.Property(x => x.PostalCode)
                .HasColumnName("POSTALCODE")
                .HasColumnType("TEXT")
                .IsRequired();

            _ = builder.Property(x => x.Country)
                .HasColumnName("COUNTRY")
                .HasColumnType("NUMERIC(4,0)")
                .IsRequired();

            _ = builder.Property(X => X.Name)
                .HasColumnName("NAME")
                .IsRequired();
            _ = builder.HasIndex(X => X.Name)
                .HasDatabaseName("IDX_CITY_NAME");
        }
    }
}