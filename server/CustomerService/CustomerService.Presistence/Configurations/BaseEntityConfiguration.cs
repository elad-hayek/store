using CustomerService.Domain.Primitives;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace CustomerService.Presistence.Configurations;

internal abstract class BaseEntityConfiguration<T, TIdType>: IEntityTypeConfiguration<T> 
    where T: Entity<TIdType>
    where TIdType : notnull
{
    public void Configure(EntityTypeBuilder<T> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id).HasColumnName("ID").ValueGeneratedOnAdd().IsRequired();
        builder.Property(e => e.CreatedDate).HasColumnName("CreatedDate").HasDefaultValueSql("getdate()").IsRequired();
        builder.Property(e => e.UpdatedDate).HasColumnName("UpdateDate");
        builder.Property(e => e.UpdatingUserId).HasColumnName("UpdatingUserID");
        builder.Property(e => e.DeletedDate).HasColumnName("DeletedDate");
        builder.Property(e => e.DeletedBy).HasColumnName("DeletedBy");

        ConfigureEntity(builder);
    }

    public abstract void ConfigureEntity(EntityTypeBuilder<T> builder);
}
