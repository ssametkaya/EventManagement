using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Configuration
{
    public class CategoryMapping : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.CategoryID);
            builder.Property(x => x.CategoryID).UseIdentityColumn(1);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(60);

            builder.HasData(
               new Category { CategoryID = 1, Name = "Spor" },
               new Category { CategoryID = 2, Name = "Online" },
               new Category { CategoryID = 3, Name = "Sinema" },
               new Category { CategoryID = 4, Name = "Müzik" }
               );
        }
    }
}
