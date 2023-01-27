using CustomerService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CustomerService.Presistence.Configurations;

internal sealed class CustomerConfiguration : BaseEntityConfiguration<Customer>
{
    public override void ConfigureEntity(EntityTypeBuilder<Customer> builder)
    {
        builder.ToTable("Users");
        builder.Property(c => c.FirstName).HasColumnName("FirstName").HasMaxLength(50).IsRequired();
        builder.Property(c => c.LastName).HasColumnName("LastName").HasMaxLength(50).IsRequired();
        builder.Property(c => c.Email).HasColumnName("Email").HasMaxLength(50).IsRequired();
        builder.Property(c => c.PhoneNumber).HasColumnName("PhoneNumber").HasMaxLength(20).IsRequired();
    }
}
