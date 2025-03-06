using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockControl.Core.Models;

namespace StockControl.Api.Data.Mappings
{
    public class ProductMapping : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).IsRequired().HasColumnType("NVARCHAR").HasMaxLength(100);
            builder.Property(x => x.MovimentType).IsRequired().HasColumnType("TINYINT");
            builder.Property(x => x.DateStockMovement).IsRequired();
            builder.Property(x => x.Quantity).IsRequired().HasColumnType("SMALLINT");
            builder.Property(x => x.CategoryId).IsRequired().HasColumnType("INT");
            builder.Property(x => x.UserId).IsRequired().HasColumnType("NVARCHAR").HasMaxLength(160);
            builder.HasOne(x => x.Category) // Relacionamento 1:N
               .WithMany(c => c.Products)
               .HasForeignKey(x => x.CategoryId)
               .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
