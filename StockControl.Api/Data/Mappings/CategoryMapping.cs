using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockControl.Core.Models;

namespace StockControl.Api.Data.Mappings
{
    public class CategoryMapping : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).IsRequired().HasColumnType("NVARCHAR").HasMaxLength(100);
            builder.Property(x => x.Description).IsRequired().HasColumnType("NVARCHAR").HasMaxLength(100);
            builder.Property(x => x.UserId).IsRequired().HasColumnType("NVARCHAR").HasMaxLength(160);

        }
    }
}
