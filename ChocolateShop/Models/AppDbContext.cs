using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChocolateShop.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :
            base(options)
        {

        }

        public DbSet<Chocolate> Chocolates { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Dark Chocolate" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "White Chocolate" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Milk Chocolate" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 4, CategoryName = "Unsweetened Chocolate" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 5, CategoryName = "Candy Chocolate" });

            modelBuilder.Entity<Chocolate>().HasData(new Chocolate
            { 
                ChocolateId =1,
                Name = "Normal Dark Chocolate",
                Price =4.99M,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam at turpis ac sapien tincidunt placerat. Duis at neque et risus posuere consectetur. Morbi luctus, ante sit amet ultricies blandit, erat lectus consectetur diam, nec eleifend velit libero aliquam purus. Pellentesque est enim, tempus at auctor non, tempor non lacus. Cras a est quis orci iaculis volutpat ac at nunc. Proin tortor justo, imperdiet gravida ligula ullamcorper, volutpat cursus felis. Nullam commodo sapien libero, nec tincidunt tortor facilisis at. Vivamus id turpis dignissim, gravida lacus sed, eleifend sem. In ultricies nibh in placerat viverra. Pellentesque consectetur ut dui eu mollis. Quisque rhoncus odio eget quam placerat, vitae feugiat risus lacinia. Vivamus semper aliquam tellus ac pellentesque. Aenean sollicitudin gravida lorem, in vestibulum est luctus eu.",
                CategoryId = 1,
                ImageUrl= "https://drive.google.com/file/d/1p1Kh7LTTkG6y-YW-hMqSKU9jzrAcf2Ye/view?usp=sharing",
                ImageThumbnailUrl= "https://drive.google.com/file/d/1Xe10fFHJt1Srvt1yth5H2L_W3t_wPb93/view?usp=sharing",
                IsInStock=true,
                IsOnSale=true

            });
            modelBuilder.Entity<Chocolate>().HasData(new Chocolate
            {
                ChocolateId = 2,
                Name = "Assorted Dark Chocolate",
                Price = 3.95M,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam at turpis tincidunt placerat. Duis at neque et risus posuere consectetur. Morbi luctus, ante sit amet ultricies blandit, erat lectus consectetur diam, nec eleifend velit libero aliquam purus. Pellentesque est enim, tempus at auctor non, tempor non lacus. Cras a est quis orci iaculis volutpat ac at nunc. Proin tortor justo, imperdiet gravida ligula ullamcorper, volutpat cursus felis. Nullam commodo sapien libero, nec tincidunt tortor facilisis at. Vivamus id turpis dignissim, gravida lacus sed, eleifend sem. In ultricies nibh in placerat viverra. Pellentesque consectetur ut dui eu mollis. Quisque rhoncus odio eget quam placerat, vitae feugiat risus lacinia. Vivamus semper aliquam tellus ac pellentesque. Aenean sollicitudin gravida lorem, in vestibulum est luctus eu.",
                CategoryId = 1,
                ImageUrl = "https://drive.google.com/file/d/1gXGqftQhfWKufx2jBlPN5td_35xPJlBm/view?usp=sharing",
                ImageThumbnailUrl = "https://drive.google.com/file/d/1SUT3lawwRdqX-v2tIIuvcOOxfoZXOmd1/view?usp=sharing",
                IsInStock = true,
                IsOnSale = true

            });
            modelBuilder.Entity<Chocolate>().HasData(new Chocolate
            {
                ChocolateId = 3,
                Name = "Normal White Chocolate",
                Price = 6.99M,
                Description = "Duis vestibulum finibus ipsum vitae fermentum. Mauris condimentum lacinia fringilla. Morbi sit amet auctor enim. In eget ultrices urna. Aenean consectetur mattis metus ac molestie. Proin a tempus sapien. Nam suscipit ac erat a sagittis. In porttitor risus mi, eget accumsan lorem lobortis fermentum. Nam at risus nec nulla luctus cursus. Duis semper vel elit eget maximus. Curabitur eu auctor mi, vitae vestibulum est. Pellentesque at sollicitudin massa. In in convallis magna, interdum porttitor neque. Aenean lacinia odio ac justo blandit rhoncus.",
                CategoryId = 2,
                ImageUrl = "https://drive.google.com/file/d/1vFmeP0kHEOKtHEKv0zwtXZFNwbVabSgQ/view?usp=sharing",
                ImageThumbnailUrl = "https://drive.google.com/file/d/13NFnQFvvqvi4FPLpwqwKYnULEV4ucyTt/view?usp=sharing",
                IsInStock = true,
                IsOnSale = true

            });
            modelBuilder.Entity<Chocolate>().HasData(new Chocolate
            {
                ChocolateId = 4,
                Name = "Assorted White Chocolate",
                Price = 6.49M,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam at turpis ac sapien tincidunt placerat. Duis at neque et risus posuere consectetur. Morbi luctus, ante sit amet ultricies blandit, erat lectus consectetur diam, nec eleifend velit libero aliquam purus. Pellentesque est enim, tempus at auctor non, tempor non lacus. Cras a est quis orci iaculis volutpat ac at nunc. Proin tortor justo, imperdiet gravida ligula ullamcorper, volutpat cursus felis. Nullam commodo sapien libero, nec tincidunt tortor facilisis at. Vivamus id turpis dignissim, gravida lacus sed, eleifend sem. In ultricies nibh in placerat viverra. Pellentesque consectetur ut dui eu mollis. Quisque eget quam placerat, vitae feugiat risus lacinia. Vivamus semper aliquam tellus ac pellentesque. Aenean sollicitudin gravida lorem, in vestibulum est luctus eu.",
                CategoryId = 2,
                ImageUrl = "https://drive.google.com/file/d/1TPwOWSSIsYdkOEtwWjFR7Hgc6in3apaz/view?usp=sharing",
                ImageThumbnailUrl = "https://drive.google.com/file/d/191Xju9NUeDxdWpbVMMMe4Pd4nczdrLUO/view?usp=sharing",
                IsInStock = true,
                IsOnSale = false

            });
            modelBuilder.Entity<Chocolate>().HasData(new Chocolate
            {
                ChocolateId = 5,
                Name = "Normal Milk Chocolate",
                Price = 7.99M,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam at turpis ac sapien tincidunt placerat. Duis at neque et risus posuere consectetur. Morbi luctus, ante sit amet ultricies erat lectus consectetur diam, nec eleifend velit libero aliquam purus. Pellentesque est enim, tempus at auctor non, tempor non lacus. Cras a est quis orci iaculis volutpat ac at nunc. Proin tortor justo, imperdiet gravida ligula ullamcorper, volutpat cursus felis. Nullam commodo sapien libero, nec tincidunt tortor facilisis at. Vivamus id turpis dignissim, gravida lacus sed, eleifend sem. In ultricies nibh in placerat viverra. Pellentesque consectetur ut dui eu mollis. Quisque rhoncus odio eget quam placerat, vitae feugiat risus lacinia. Vivamus semper aliquam tellus ac pellentesque. Aenean sollicitudin gravida lorem, in vestibulum est luctus eu.",
                CategoryId = 3,
                ImageUrl = "https://drive.google.com/file/d/1U5bwHhaR3ZK5EojZngTcQtNGMFgOY1kP/view?usp=sharing",
                ImageThumbnailUrl = "https://drive.google.com/file/d/1Xe10fFHJt1Srvt1yth5H2L_W3t_wPb93/view?usp=sharing",
                IsInStock = true,
                IsOnSale = false

            });
            modelBuilder.Entity<Chocolate>().HasData(new Chocolate
            {
                ChocolateId = 6,
                Name = "Assorted Milk Chocolate",
                Price = 9.99M,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam at turpis ac sapien tincidunt placerat. Duis at neque et risus posuere consectetur. Morbi luctus, ultricies blandit, erat lectus consectetur diam, nec eleifend velit libero aliquam purus. Pellentesque est enim, tempus at auctor non, tempor non lacus. Cras a est quis orci iaculis volutpat ac at nunc. Proin tortor justo, imperdiet gravida ligula ullamcorper, volutpat cursus felis. Nullam commodo sapien libero, nec tincidunt tortor facilisis at. Vivamus id turpis dignissim, gravida lacus sed, eleifend sem. In ultricies nibh in placerat viverra. Pellentesque consectetur ut dui eu mollis. Quisque rhoncus odio eget quam placerat, vitae feugiat risus lacinia. Vivamus semper aliquam tellus ac pellentesque. Aenean sollicitudin gravida lorem, in vestibulum est luctus eu.",
                CategoryId = 3,
                ImageUrl = "https://drive.google.com/file/d/1pCCeFGAcGChD0XkWJ1PXZvjHJSu_0XaI/view?usp=sharing",
                ImageThumbnailUrl = "https://drive.google.com/file/d/1Xa2YZzrS6GPJIAFvxj8QXa0oJxscV1kO/view?usp=sharing",
                IsInStock = true,
                IsOnSale = true

            });
            modelBuilder.Entity<Chocolate>().HasData(new Chocolate
            {
                ChocolateId = 7,
                Name = "Normal Unsweetened Chocolate",
                Price = 2.99M,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam at turpis ac sapien tincidunt placerat. Duis at neque et risus posuere consectetur. Morbi luctus, ante sit amet ultricies blandit, erat lectus, nec eleifend velit libero aliquam purus. Pellentesque est enim, tempus at auctor non, tempor non lacus. Cras a est quis orci iaculis volutpat ac at nunc. Proin tortor justo, imperdiet gravida ligula ullamcorper, volutpat cursus felis. Nullam commodo sapien libero, nec tincidunt tortor facilisis at. Vivamus id turpis dignissim, gravida lacus sed, eleifend sem. In ultricies nibh in placerat viverra. Pellentesque consectetur ut dui eu mollis. Quisque rhoncus odio eget quam placerat, vitae feugiat risus lacinia. Vivamus semper aliquam tellus ac pellentesque. Aenean sollicitudin gravida lorem, in vestibulum est luctus eu.",
                CategoryId = 4,
                ImageUrl = "https://drive.google.com/file/d/1DKRua7u4NpU0Am0YGq14avPfrRB_hZia/view?usp=sharing",
                ImageThumbnailUrl = "https://drive.google.com/file/d/1-fjM8OSx4N2r0s91FZ9hxYx6a0kwH3b4/view?usp=sharing",
                IsInStock = true,
                IsOnSale = true

            });
            modelBuilder.Entity<Chocolate>().HasData(new Chocolate
            {
                ChocolateId = 8,
                Name = "Assorted Unsweetened Chocolate",
                Price = 3.49M,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam at turpis ac sapien tincidunt placerat. Duis at neque et risus posuere consectetur. Morbi luctus, ante sit amet ultricies blandit, erat lectus consectetur diam, nec eleifend. Pellentesque est enim, tempus at auctor non, tempor non lacus. Cras a est quis orci iaculis volutpat ac at nunc. Proin tortor justo, imperdiet gravida ligula ullamcorper, volutpat cursus felis. Nullam commodo sapien libero, nec tincidunt tortor facilisis at. Vivamus id turpis dignissim, gravida lacus sed, eleifend sem. In ultricies nibh in placerat viverra. Pellentesque consectetur ut dui eu mollis. Quisque rhoncus odio eget quam placerat, vitae feugiat risus lacinia. Vivamus semper aliquam tellus ac pellentesque. Aenean sollicitudin gravida lorem, in vestibulum est luctus eu.",
                CategoryId = 4,
                ImageUrl = "https://drive.google.com/file/d/1ZQmTOt7K8DHvaPiiKX-m9Phlp3SKB8oY/view?usp=sharing",
                ImageThumbnailUrl = "https://drive.google.com/file/d/17-A2mxVAZXVFwiToPIss5_mQfQ2fGaSh/view?usp=sharing",
                IsInStock = true,
                IsOnSale = true

            });
            modelBuilder.Entity<Chocolate>().HasData(new Chocolate
            {
                ChocolateId = 9,
                Name = "Normal Candy Chocolate",
                Price = 3.99M,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam at turpis ac sapien placerat. Duis at neque et risus posuere consectetur. Morbi luctus, ante sit amet ultricies blandit, erat lectus consectetur diam, nec eleifend velit libero aliquam purus. Pellentesque est enim, tempus at auctor non, tempor non lacus. Cras a est quis orci iaculis volutpat ac at nunc. Proin tortor justo, imperdiet gravida ligula ullamcorper, volutpat cursus felis. Nullam commodo sapien libero, nec tincidunt tortor facilisis at. Vivamus id turpis dignissim, gravida lacus sed, eleifend sem. In ultricies nibh in placerat viverra. Pellentesque consectetur ut dui eu mollis. Quisque rhoncus odio eget quam placerat, vitae feugiat risus lacinia. Vivamus semper aliquam tellus ac pellentesque. Aenean sollicitudin gravida lorem, in vestibulum est luctus eu.",
                CategoryId = 5,
                ImageUrl = "https://drive.google.com/file/d/1Py3x1acnQ5_AHCkEY1vp-XaXJS_ozBiu/view?usp=sharing",
                ImageThumbnailUrl = "https://drive.google.com/file/d/1_BdYpdrqi47Vemz3EKE52T4N3vMcAYrq/view?usp=sharing",
                IsInStock = true,
                IsOnSale = false

            });
            modelBuilder.Entity<Chocolate>().HasData(new Chocolate
            {
                ChocolateId = 10,
                Name = "Assorted Candy Chocolate",
                Price = 4.49M,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam at turpis ac  tincidunt placerat. Duis at neque et risus posuere consectetur. Morbi luctus, ante sit amet ultricies blandit, erat lectus consectetur diam, nec eleifend velit libero aliquam purus. Pellentesque est enim, tempus at auctor non, tempor non lacus. Cras a est quis orci iaculis volutpat ac at nunc. Proin tortor justo, imperdiet gravida ligula ullamcorper, volutpat cursus felis. Nullam commodo sapien libero, nec tincidunt tortor facilisis at. Vivamus id turpis dignissim, gravida lacus sed, eleifend sem. In ultricies nibh in placerat viverra. Pellentesque consectetur ut dui eu mollis. Quisque rhoncus odio eget quam placerat, vitae feugiat risus lacinia. Vivamus semper aliquam tellus ac pellentesque. Aenean sollicitudin gravida lorem, in vestibulum est luctus eu.",
                CategoryId = 5,
                ImageUrl = "https://drive.google.com/file/d/1A852qmM2GkxXzKyjaRHB3QmUfIoZHcqJ/view?usp=sharing",
                ImageThumbnailUrl = "https://drive.google.com/file/d/1VkDcXczudijOoudUBR6SKssa4lgJYnH4/view?usp=sharing",
                IsInStock = true,
                IsOnSale = true

            });
        }


    }
}
