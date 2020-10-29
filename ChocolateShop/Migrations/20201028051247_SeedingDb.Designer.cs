﻿// <auto-generated />
using ChocolateShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ChocolateShop.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20201028051247_SeedingDb")]
    partial class SeedingDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ChocolateShop.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Dark Chocolate"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "White Chocolate"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Milk Chocolate"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Unsweetened Chocolate"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Candy Chocolate"
                        });
                });

            modelBuilder.Entity("ChocolateShop.Models.Chocolate", b =>
                {
                    b.Property<int>("ChocolateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsInStock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOnSale")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ChocolateId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Chocolates");

                    b.HasData(
                        new
                        {
                            ChocolateId = 1,
                            CategoryId = 1,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam at turpis ac sapien tincidunt placerat. Duis at neque et risus posuere consectetur. Morbi luctus, ante sit amet ultricies blandit, erat lectus consectetur diam, nec eleifend velit libero aliquam purus. Pellentesque est enim, tempus at auctor non, tempor non lacus. Cras a est quis orci iaculis volutpat ac at nunc. Proin tortor justo, imperdiet gravida ligula ullamcorper, volutpat cursus felis. Nullam commodo sapien libero, nec tincidunt tortor facilisis at. Vivamus id turpis dignissim, gravida lacus sed, eleifend sem. In ultricies nibh in placerat viverra. Pellentesque consectetur ut dui eu mollis. Quisque rhoncus odio eget quam placerat, vitae feugiat risus lacinia. Vivamus semper aliquam tellus ac pellentesque. Aenean sollicitudin gravida lorem, in vestibulum est luctus eu.",
                            ImageThumbnailUrl = "https://drive.google.com/file/d/1Xe10fFHJt1Srvt1yth5H2L_W3t_wPb93/view?usp=sharing",
                            ImageUrl = "https://drive.google.com/file/d/1p1Kh7LTTkG6y-YW-hMqSKU9jzrAcf2Ye/view?usp=sharing",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Normal Dark Chocolate",
                            Price = 4.99m
                        },
                        new
                        {
                            ChocolateId = 2,
                            CategoryId = 1,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam at turpis tincidunt placerat. Duis at neque et risus posuere consectetur. Morbi luctus, ante sit amet ultricies blandit, erat lectus consectetur diam, nec eleifend velit libero aliquam purus. Pellentesque est enim, tempus at auctor non, tempor non lacus. Cras a est quis orci iaculis volutpat ac at nunc. Proin tortor justo, imperdiet gravida ligula ullamcorper, volutpat cursus felis. Nullam commodo sapien libero, nec tincidunt tortor facilisis at. Vivamus id turpis dignissim, gravida lacus sed, eleifend sem. In ultricies nibh in placerat viverra. Pellentesque consectetur ut dui eu mollis. Quisque rhoncus odio eget quam placerat, vitae feugiat risus lacinia. Vivamus semper aliquam tellus ac pellentesque. Aenean sollicitudin gravida lorem, in vestibulum est luctus eu.",
                            ImageThumbnailUrl = "https://drive.google.com/file/d/1SUT3lawwRdqX-v2tIIuvcOOxfoZXOmd1/view?usp=sharing",
                            ImageUrl = "https://drive.google.com/file/d/1gXGqftQhfWKufx2jBlPN5td_35xPJlBm/view?usp=sharing",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Assorted Dark Chocolate",
                            Price = 3.95m
                        },
                        new
                        {
                            ChocolateId = 3,
                            CategoryId = 2,
                            Description = "Duis vestibulum finibus ipsum vitae fermentum. Mauris condimentum lacinia fringilla. Morbi sit amet auctor enim. In eget ultrices urna. Aenean consectetur mattis metus ac molestie. Proin a tempus sapien. Nam suscipit ac erat a sagittis. In porttitor risus mi, eget accumsan lorem lobortis fermentum. Nam at risus nec nulla luctus cursus. Duis semper vel elit eget maximus. Curabitur eu auctor mi, vitae vestibulum est. Pellentesque at sollicitudin massa. In in convallis magna, interdum porttitor neque. Aenean lacinia odio ac justo blandit rhoncus.",
                            ImageThumbnailUrl = "https://drive.google.com/file/d/13NFnQFvvqvi4FPLpwqwKYnULEV4ucyTt/view?usp=sharing",
                            ImageUrl = "https://drive.google.com/file/d/1vFmeP0kHEOKtHEKv0zwtXZFNwbVabSgQ/view?usp=sharing",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Normal White Chocolate",
                            Price = 6.99m
                        },
                        new
                        {
                            ChocolateId = 4,
                            CategoryId = 2,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam at turpis ac sapien tincidunt placerat. Duis at neque et risus posuere consectetur. Morbi luctus, ante sit amet ultricies blandit, erat lectus consectetur diam, nec eleifend velit libero aliquam purus. Pellentesque est enim, tempus at auctor non, tempor non lacus. Cras a est quis orci iaculis volutpat ac at nunc. Proin tortor justo, imperdiet gravida ligula ullamcorper, volutpat cursus felis. Nullam commodo sapien libero, nec tincidunt tortor facilisis at. Vivamus id turpis dignissim, gravida lacus sed, eleifend sem. In ultricies nibh in placerat viverra. Pellentesque consectetur ut dui eu mollis. Quisque eget quam placerat, vitae feugiat risus lacinia. Vivamus semper aliquam tellus ac pellentesque. Aenean sollicitudin gravida lorem, in vestibulum est luctus eu.",
                            ImageThumbnailUrl = "https://drive.google.com/file/d/191Xju9NUeDxdWpbVMMMe4Pd4nczdrLUO/view?usp=sharing",
                            ImageUrl = "https://drive.google.com/file/d/1TPwOWSSIsYdkOEtwWjFR7Hgc6in3apaz/view?usp=sharing",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Assorted White Chocolate",
                            Price = 6.49m
                        },
                        new
                        {
                            ChocolateId = 5,
                            CategoryId = 3,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam at turpis ac sapien tincidunt placerat. Duis at neque et risus posuere consectetur. Morbi luctus, ante sit amet ultricies erat lectus consectetur diam, nec eleifend velit libero aliquam purus. Pellentesque est enim, tempus at auctor non, tempor non lacus. Cras a est quis orci iaculis volutpat ac at nunc. Proin tortor justo, imperdiet gravida ligula ullamcorper, volutpat cursus felis. Nullam commodo sapien libero, nec tincidunt tortor facilisis at. Vivamus id turpis dignissim, gravida lacus sed, eleifend sem. In ultricies nibh in placerat viverra. Pellentesque consectetur ut dui eu mollis. Quisque rhoncus odio eget quam placerat, vitae feugiat risus lacinia. Vivamus semper aliquam tellus ac pellentesque. Aenean sollicitudin gravida lorem, in vestibulum est luctus eu.",
                            ImageThumbnailUrl = "https://drive.google.com/file/d/1Xe10fFHJt1Srvt1yth5H2L_W3t_wPb93/view?usp=sharing",
                            ImageUrl = "https://drive.google.com/file/d/1U5bwHhaR3ZK5EojZngTcQtNGMFgOY1kP/view?usp=sharing",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Normal Milk Chocolate",
                            Price = 7.99m
                        },
                        new
                        {
                            ChocolateId = 6,
                            CategoryId = 3,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam at turpis ac sapien tincidunt placerat. Duis at neque et risus posuere consectetur. Morbi luctus, ultricies blandit, erat lectus consectetur diam, nec eleifend velit libero aliquam purus. Pellentesque est enim, tempus at auctor non, tempor non lacus. Cras a est quis orci iaculis volutpat ac at nunc. Proin tortor justo, imperdiet gravida ligula ullamcorper, volutpat cursus felis. Nullam commodo sapien libero, nec tincidunt tortor facilisis at. Vivamus id turpis dignissim, gravida lacus sed, eleifend sem. In ultricies nibh in placerat viverra. Pellentesque consectetur ut dui eu mollis. Quisque rhoncus odio eget quam placerat, vitae feugiat risus lacinia. Vivamus semper aliquam tellus ac pellentesque. Aenean sollicitudin gravida lorem, in vestibulum est luctus eu.",
                            ImageThumbnailUrl = "https://drive.google.com/file/d/1Xa2YZzrS6GPJIAFvxj8QXa0oJxscV1kO/view?usp=sharing",
                            ImageUrl = "https://drive.google.com/file/d/1pCCeFGAcGChD0XkWJ1PXZvjHJSu_0XaI/view?usp=sharing",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Assorted Milk Chocolate",
                            Price = 9.99m
                        },
                        new
                        {
                            ChocolateId = 7,
                            CategoryId = 4,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam at turpis ac sapien tincidunt placerat. Duis at neque et risus posuere consectetur. Morbi luctus, ante sit amet ultricies blandit, erat lectus, nec eleifend velit libero aliquam purus. Pellentesque est enim, tempus at auctor non, tempor non lacus. Cras a est quis orci iaculis volutpat ac at nunc. Proin tortor justo, imperdiet gravida ligula ullamcorper, volutpat cursus felis. Nullam commodo sapien libero, nec tincidunt tortor facilisis at. Vivamus id turpis dignissim, gravida lacus sed, eleifend sem. In ultricies nibh in placerat viverra. Pellentesque consectetur ut dui eu mollis. Quisque rhoncus odio eget quam placerat, vitae feugiat risus lacinia. Vivamus semper aliquam tellus ac pellentesque. Aenean sollicitudin gravida lorem, in vestibulum est luctus eu.",
                            ImageThumbnailUrl = "https://drive.google.com/file/d/1-fjM8OSx4N2r0s91FZ9hxYx6a0kwH3b4/view?usp=sharing",
                            ImageUrl = "https://drive.google.com/file/d/1DKRua7u4NpU0Am0YGq14avPfrRB_hZia/view?usp=sharing",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Normal Unsweetened Chocolate",
                            Price = 2.99m
                        },
                        new
                        {
                            ChocolateId = 8,
                            CategoryId = 4,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam at turpis ac sapien tincidunt placerat. Duis at neque et risus posuere consectetur. Morbi luctus, ante sit amet ultricies blandit, erat lectus consectetur diam, nec eleifend. Pellentesque est enim, tempus at auctor non, tempor non lacus. Cras a est quis orci iaculis volutpat ac at nunc. Proin tortor justo, imperdiet gravida ligula ullamcorper, volutpat cursus felis. Nullam commodo sapien libero, nec tincidunt tortor facilisis at. Vivamus id turpis dignissim, gravida lacus sed, eleifend sem. In ultricies nibh in placerat viverra. Pellentesque consectetur ut dui eu mollis. Quisque rhoncus odio eget quam placerat, vitae feugiat risus lacinia. Vivamus semper aliquam tellus ac pellentesque. Aenean sollicitudin gravida lorem, in vestibulum est luctus eu.",
                            ImageThumbnailUrl = "https://drive.google.com/file/d/17-A2mxVAZXVFwiToPIss5_mQfQ2fGaSh/view?usp=sharing",
                            ImageUrl = "https://drive.google.com/file/d/1ZQmTOt7K8DHvaPiiKX-m9Phlp3SKB8oY/view?usp=sharing",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Assorted Unsweetened Chocolate",
                            Price = 3.49m
                        },
                        new
                        {
                            ChocolateId = 9,
                            CategoryId = 5,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam at turpis ac sapien placerat. Duis at neque et risus posuere consectetur. Morbi luctus, ante sit amet ultricies blandit, erat lectus consectetur diam, nec eleifend velit libero aliquam purus. Pellentesque est enim, tempus at auctor non, tempor non lacus. Cras a est quis orci iaculis volutpat ac at nunc. Proin tortor justo, imperdiet gravida ligula ullamcorper, volutpat cursus felis. Nullam commodo sapien libero, nec tincidunt tortor facilisis at. Vivamus id turpis dignissim, gravida lacus sed, eleifend sem. In ultricies nibh in placerat viverra. Pellentesque consectetur ut dui eu mollis. Quisque rhoncus odio eget quam placerat, vitae feugiat risus lacinia. Vivamus semper aliquam tellus ac pellentesque. Aenean sollicitudin gravida lorem, in vestibulum est luctus eu.",
                            ImageThumbnailUrl = "https://drive.google.com/file/d/1_BdYpdrqi47Vemz3EKE52T4N3vMcAYrq/view?usp=sharing",
                            ImageUrl = "https://drive.google.com/file/d/1Py3x1acnQ5_AHCkEY1vp-XaXJS_ozBiu/view?usp=sharing",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Normal Candy Chocolate",
                            Price = 3.99m
                        },
                        new
                        {
                            ChocolateId = 10,
                            CategoryId = 5,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam at turpis ac  tincidunt placerat. Duis at neque et risus posuere consectetur. Morbi luctus, ante sit amet ultricies blandit, erat lectus consectetur diam, nec eleifend velit libero aliquam purus. Pellentesque est enim, tempus at auctor non, tempor non lacus. Cras a est quis orci iaculis volutpat ac at nunc. Proin tortor justo, imperdiet gravida ligula ullamcorper, volutpat cursus felis. Nullam commodo sapien libero, nec tincidunt tortor facilisis at. Vivamus id turpis dignissim, gravida lacus sed, eleifend sem. In ultricies nibh in placerat viverra. Pellentesque consectetur ut dui eu mollis. Quisque rhoncus odio eget quam placerat, vitae feugiat risus lacinia. Vivamus semper aliquam tellus ac pellentesque. Aenean sollicitudin gravida lorem, in vestibulum est luctus eu.",
                            ImageThumbnailUrl = "https://drive.google.com/file/d/1VkDcXczudijOoudUBR6SKssa4lgJYnH4/view?usp=sharing",
                            ImageUrl = "https://drive.google.com/file/d/1A852qmM2GkxXzKyjaRHB3QmUfIoZHcqJ/view?usp=sharing",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Assorted Candy Chocolate",
                            Price = 4.49m
                        });
                });

            modelBuilder.Entity("ChocolateShop.Models.Chocolate", b =>
                {
                    b.HasOne("ChocolateShop.Models.Category", "Category")
                        .WithMany("Chocolates")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}