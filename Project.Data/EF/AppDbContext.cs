using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project.Data.Configurations;
using Project.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.EF
{
    public class AppDbContext : IdentityDbContext<AppUser> 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);
            modelbuilder.ApplyConfiguration(new AppUserConfiguration());
            modelbuilder.ApplyConfiguration(new MediasConfiguration());
            modelbuilder.ApplyConfiguration(new ProductConfiguration());
            modelbuilder.ApplyConfiguration(new ReviewsConfiguration());
            modelbuilder.ApplyConfiguration(new CategoryConfiguration());
            modelbuilder.ApplyConfiguration(new CartConfiguration());
            modelbuilder.ApplyConfiguration(new OrderConfiguration());
            modelbuilder.ApplyConfiguration(new OrderDetailConfiguration());
            modelbuilder.ApplyConfiguration(new ImportConfiguration());
            modelbuilder.ApplyConfiguration(new ImportProductConfiguration());


            List<IdentityRole> roles = new List<IdentityRole>()
            {
                new IdentityRole{Name="Admin",NormalizedName="ADMIN"},
                new IdentityRole{Name="User",NormalizedName="USER"}
            };
            modelbuilder.Entity<IdentityRole>().HasData(roles);

            var passwordHasher = new PasswordHasher<AppUser>();
            List<AppUser> user = new List<AppUser>()
            {
                new AppUser
                {
                    UserName="user2@hotmail.com",
                    NormalizedUserName="USER2@HOTMAIL.COM",
                    Email="user2@hotmail.com",
                    NormalizedEmail="USER2@HOTMAIL.COM"
                },
                new AppUser
                {
                    UserName="user3@hotmail.com",
                    NormalizedUserName="USER3@HOTMAIL.COM",
                    Email="user3@hotmail.com",
                    NormalizedEmail="USER3@HOTMAIL.COM"
                }
            };
            modelbuilder.Entity<AppUser>().HasData(user);

            List<IdentityUserRole<string>> userRoles = new List<IdentityUserRole<string>>();
            user[0].PasswordHash = passwordHasher.HashPassword(user[0], "User.123");
            user[1].PasswordHash = passwordHasher.HashPassword(user[1], "User.321");

            userRoles.Add(new IdentityUserRole<string>
            {
                UserId = user[0].Id,
                RoleId = roles.First(x => x.Name == "User").Id
            });
            userRoles.Add(new IdentityUserRole<string>
            {
                UserId = user[1].Id,
                RoleId = roles.First(x => x.Name == "Admin").Id
            });
            modelbuilder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        }



        public DbSet<AppUser> Users { get; set; }
        public DbSet<Medias> Medias { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Reviews> Reviews { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Import> Imports { get; set; }
        public DbSet<ImportProduct> ImportProducts { get; set; }

    }
}
