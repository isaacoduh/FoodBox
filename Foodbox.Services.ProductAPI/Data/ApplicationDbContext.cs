using Foodbox.Services.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foodbox.Services.ProductAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Samosa",
                Price = 15,
                Description = "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.",
                ImageUrl = "https://foodboxdev.blob.core.windows.net/foodboxdev/anna-tukhfatullina-food-photographer-stylist-Mzy-OjtCI70-unsplash.jpg",
                CategoryName = "Appetizer"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Paneer Tikka",
                Price = 13.99,
                Description = "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.",
                ImageUrl = "https://foodboxdev.blob.core.windows.net/foodboxdev/anna-pelzer-IGfIGP5ONV0-unsplash.jpg",
                CategoryName = "Appetizer"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "Sweet Pie",
                Price = 10.99,
                Description = "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.",
                ImageUrl = "https://foodboxdev.blob.core.windows.net/foodboxdev/chad-montano-eeqbbemH9-c-unsplash.jpg",
                CategoryName = "Dessert"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "Pav Bhaji",
                Price = 15,
                Description = "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.",
                ImageUrl = "https://foodboxdev.blob.core.windows.net/foodboxdev/davide-cantelli-jpkfc5_d-DI-unsplash.jpg",
                CategoryName = "Entree"
            });
        }
    }
}
