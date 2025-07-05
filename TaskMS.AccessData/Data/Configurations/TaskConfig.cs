using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskMS.AccessData.Entites;

namespace TaskMS.AccessData.Data.Configurations
{

    internal class TaskConfig : IEntityTypeConfiguration<task>
    {
        public void Configure(EntityTypeBuilder<task> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).ValueGeneratedOnAdd();

            builder.Property(t => t.Title).HasMaxLength(70);
            builder.Property(t => t.Description).HasColumnType("NVARCHAR(MAX)");

            builder.Property(t => t.Status)
                .HasConversion<String>()
                .HasMaxLength(20);


            builder.Property(t => t.Priority)
                .HasConversion<string>()
                .HasMaxLength(20);



        }
    }
}
