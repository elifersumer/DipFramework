using DipFramework.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipFramework.DataAccess.EntityFramework.Concrete.Mappings
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.ProductId);

            builder.Property(p => p.CategoryId).HasColumnName("CategoryID");
            builder.Property(p => p.ProductName).HasColumnName("ProductName");
            builder.Property(p => p.SupplierId).HasColumnName("SupplierID");
            builder.Property(p => p.QuantityPerUnit).HasColumnName("QuantityPerUnit");
            builder.Property(p => p.UnitPrice).HasColumnName("UnitPrice");
            builder.Property(p => p.UnitsInStock).HasColumnName("UnitsInStock");
            builder.Property(p => p.UnitsOnOrder).HasColumnName("UnitsOnOrder");
            builder.Property(p => p.ReorderLevel).HasColumnName("ReorderLevel");
        }
    }
}
