using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TodoList.Business.Entities;

namespace TodoList.Data.Mappings
{
    public class ItemMap : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.HasKey(i => i.Id);

            builder.Property(i => i.Title)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(i => i.Description)
                .HasMaxLength(1000)
                .IsRequired();
        }
    }
}
