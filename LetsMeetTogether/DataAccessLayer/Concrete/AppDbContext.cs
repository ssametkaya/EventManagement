using DataAccessLayer.Configuration;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class AppDbContext : IdentityDbContext<AppUser, AppRole, string>
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<MyEvent> MyEvents { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CategoryMapping());
            builder.ApplyConfiguration(new CityMapping());
            builder.ApplyConfiguration(new EventMapping());

            //Burada otomatik oluşturması gereken Id yi oluşturmuyor. 
            builder.Entity<AppUser>()
            .Property(e => e.Id)
            .ValueGeneratedOnAdd();
            builder.Entity<AppRole>()
           .Property(e => e.Id)
           .ValueGeneratedOnAdd();
            base.OnModelCreating(builder);
            //modelBuilder.Ignore<IdentityUserLogin<string>>();
            //modelBuilder.Ignore<IdentityUserRole<string>>();
            //modelBuilder.Ignore<IdentityUserClaim<string>>();
            builder.Ignore<IdentityUserToken<string>>();
            //modelBuilder.Ignore<IdentityUser<string>>();
            //modelBuilder.Ignore<AppUser>();

        }
    }
}
