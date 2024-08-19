using ElsaQuickstarts.ConsoleApp.HelloWorld.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ElsaQuickstarts.ConsoleApp.HelloWorld.Data
{
    public class UnitConfiguration : IEntityTypeConfiguration<Unit>
    {
        public void Configure(EntityTypeBuilder<Unit> builder)
        {
            builder.HasMany(u => u.Employees)
                .WithOne(e => e.Unit)
                .HasForeignKey(e => e.UnitId);
        }
    }
}
