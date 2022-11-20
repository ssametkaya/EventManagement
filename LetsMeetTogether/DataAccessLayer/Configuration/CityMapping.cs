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
    public class CityMapping : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasKey(x => x.CityID);
            builder.Property(x => x.CityID).UseIdentityColumn(1);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(20);


            builder.HasData(
               new City { CityID = 1, Name = "İstanbul"},
               new City { CityID = 2, Name = "Ankara" },
               new City { CityID = 3, Name = "Bursa" },
               new City { CityID = 4, Name = "İzmir" },
               new City { CityID = 5, Name = "Antalya" }
               );
        }
    }
}
