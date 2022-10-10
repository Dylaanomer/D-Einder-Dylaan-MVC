using D_Einder_Dylaan_MVC.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace D_Einder_Dylaan_MVC.Data
{
    public class DataDbContext : IdentityDbContext
    {
        public DbSet<Bestellingen> Bestellingen { get; set; }

        public DbSet<Ingredienten> Ingredienten { get; set; }

        public DbSet<Menu> Menu { get; set; }

        public DbSet<MenuItems> MenuItems { get; set; }

        public DbSet<Reservatie> Reservatie { get; set; }

        public DbSet<Tafel> Tafel { get; set; }

       

        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options)
        {
        }



        public DbSet<User> ApplicationUser { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }



    }
}
