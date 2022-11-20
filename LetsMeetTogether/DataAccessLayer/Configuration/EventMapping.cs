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
    public class EventMapping : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.HasKey(x => x.EventID);
            builder.Property(x => x.EventID).UseIdentityColumn(1);
            builder.Property(x => x.EventName).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Capacity).IsRequired();

            builder.HasCheckConstraint("CK_Cap", "[Capacity] > 0 AND [Capacity] <= 500");
            //builder.HasCheckConstraint("CK_Day", "DATEDIFF(DAY ,[ClosedDate] ,[Date]) = 5");

            builder.HasOne(x => x.Category)
                    .WithMany(x => x.Events)
                    .HasForeignKey(x => x.CategoryID);

            builder.HasOne(x => x.City)
                   .WithMany(x => x.Events)
                   .HasForeignKey(x => x.CityID);
        }
    }
}
