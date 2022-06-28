using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ShopAssignment.Data.Entities;
using ShopAssignment.Data.Enums;

namespace ShopAssignment.Data.Extensions
{
    public static class DataSeeding
    {
        public static void SeededData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
               new AppConfig() { Key = "HomeTitle", Value = "This is home page of ShopAssignment" },
               new AppConfig() { Key = "HomeKeyword", Value = "This is keyword of ShopAssignment" },
               new AppConfig() { Key = "HomeDescription", Value = "This is description of ShopAssignment" }
               );
            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi", Name = "Tiếng Việt", IsDefault = true },
                new Language() { Id = "en", Name = "English", IsDefault = false });

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Status.Active,
                },
                 new Category()
                 {
                     Id = 2,
                     IsShowOnHome = true,
                     ParentId = null,
                     SortOrder = 2,
                     Status = Status.Active
                 });

            modelBuilder.Entity<CategoryTranslation>().HasData(
                  new CategoryTranslation() { Id = 1, CategoryId = 1, Name = "Áo nam", LanguageId = "vi", SeoAlias = "ao-nam", SeoDescription = "Sản phẩm áo thời trang nam", SeoTitle = "Sản phẩm áo thời trang nam" },
                  new CategoryTranslation() { Id = 2, CategoryId = 1, Name = "Men Shirt", LanguageId = "en", SeoAlias = "men-shirt", SeoDescription = "The shirt products for men", SeoTitle = "The shirt products for men" },
                  new CategoryTranslation() { Id = 3, CategoryId = 2, Name = "Áo nữ", LanguageId = "vi", SeoAlias = "ao-nu", SeoDescription = "Sản phẩm áo thời trang nữ", SeoTitle = "Sản phẩm áo thời trang women" },
                  new CategoryTranslation() { Id = 4, CategoryId = 2, Name = "Women Shirt", LanguageId = "en", SeoAlias = "women-shirt", SeoDescription = "The shirt products for women", SeoTitle = "The shirt products for women" }
                    );

            modelBuilder.Entity<Product>().HasData(
           new Product()
           {
               Id = 1,
               DateCreated = DateTime.Now,
               OriginalPrice = 100000,
               Price = 200000,
               Stock = 0,
               ViewCount = 0,
               IsFeatured = true,
           },
           new Product()
           {
               Id = 2,
               DateCreated = DateTime.Now,
               OriginalPrice = 100000,
               Price = 200000,
               Stock = 0,
               ViewCount = 0,
               IsFeatured = true,
           },
           new Product()
           {
               Id = 3,
               DateCreated = DateTime.Now,
               OriginalPrice = 100000,
               Price = 200000,
               Stock = 0,
               ViewCount = 0,
               IsFeatured = true,
           },
           new Product()
           {
               Id = 4,
               DateCreated = DateTime.Now,
               OriginalPrice = 100000,
               Price = 200000,
               Stock = 0,
               ViewCount = 0,
               IsFeatured = true,
           },
           new Product()
           {
               Id = 5,
               DateCreated = DateTime.Now,
               OriginalPrice = 100000,
               Price = 200000,
               Stock = 0,
               ViewCount = 0,
               IsFeatured = true,
           },
           new Product()
           {
               Id = 6,
               DateCreated = DateTime.Now,
               OriginalPrice = 100000,
               Price = 200000,
               Stock = 0,
               ViewCount = 0,
               IsFeatured = true,
           },
           new Product()
           {
               Id = 7,
               DateCreated = DateTime.Now,
               OriginalPrice = 100000,
               Price = 200000,
               Stock = 0,
               ViewCount = 0,
               IsFeatured = true,
           },
           new Product()
           {
               Id = 8,
               DateCreated = DateTime.Now,
               OriginalPrice = 100000,
               Price = 200000,
               Stock = 0,
               ViewCount = 0,
               IsFeatured = true,
           }
           );
            modelBuilder.Entity<ProductTranslation>().HasData(
                 new ProductTranslation()
                 {
                     Id = 1,
                     ProductId = 1,
                     Name = "Áo sơ mi nam trắng Việt Tiến",
                     LanguageId = "vi",
                     SeoAlias = "ao-so-mi-nam-trang-viet-tien",
                     SeoDescription = "Áo sơ mi nam trắng Việt Tiến",
                     SeoTitle = "Áo sơ mi nam trắng Việt Tiến",
                     Details = "Áo sơ mi nam trắng Việt Tiến",
                     Description = "Áo sơ mi nam trắng Việt Tiến"
                 },
                    new ProductTranslation()
                    {
                        Id = 2,
                        ProductId = 1,
                        Name = "Viet Tien Men T-Shirt",
                        LanguageId = "en",
                        SeoAlias = "viet-tien-men-t-shirt",
                        SeoDescription = "Viet Tien Men T-Shirt",
                        SeoTitle = "Viet Tien Men T-Shirt",
                        Details = "Viet Tien Men T-Shirt",
                        Description = "Viet Tien Men T-Shirt"
                    },
                     new ProductTranslation()
                     {
                         Id = 3,
                         ProductId = 2,
                         Name = "Áo sơ mi nam trắng Việt Tiến",
                         LanguageId = "vi",
                         SeoAlias = "ao-so-mi-nam-trang-viet-tien",
                         SeoDescription = "Áo sơ mi nam trắng Việt Tiến",
                         SeoTitle = "Áo sơ mi nam trắng Việt Tiến",
                         Details = "Áo sơ mi nam trắng Việt Tiến",
                         Description = "Áo sơ mi nam trắng Việt Tiến"
                     },
                    new ProductTranslation()
                    {
                        Id = 4,
                        ProductId = 2,
                        Name = "Viet Tien Men T-Shirt",
                        LanguageId = "en",
                        SeoAlias = "viet-tien-men-t-shirt",
                        SeoDescription = "Viet Tien Men T-Shirt",
                        SeoTitle = "Viet Tien Men T-Shirt",
                        Details = "Viet Tien Men T-Shirt",
                        Description = "Viet Tien Men T-Shirt"
                    },
                     new ProductTranslation()
                     {
                         Id = 5,
                         ProductId = 3,
                         Name = "Áo sơ mi nam trắng Việt Tiến",
                         LanguageId = "vi",
                         SeoAlias = "ao-so-mi-nam-trang-viet-tien",
                         SeoDescription = "Áo sơ mi nam trắng Việt Tiến",
                         SeoTitle = "Áo sơ mi nam trắng Việt Tiến",
                         Details = "Áo sơ mi nam trắng Việt Tiến",
                         Description = "Áo sơ mi nam trắng Việt Tiến"
                     },
                    new ProductTranslation()
                    {
                        Id = 6,
                        ProductId = 3,
                        Name = "Viet Tien Men T-Shirt",
                        LanguageId = "en",
                        SeoAlias = "viet-tien-men-t-shirt",
                        SeoDescription = "Viet Tien Men T-Shirt",
                        SeoTitle = "Viet Tien Men T-Shirt",
                        Details = "Viet Tien Men T-Shirt",
                        Description = "Viet Tien Men T-Shirt"
                    },
                     new ProductTranslation()
                     {
                         Id = 7,
                         ProductId = 4,
                         Name = "Áo sơ mi nam trắng Việt Tiến",
                         LanguageId = "vi",
                         SeoAlias = "ao-so-mi-nam-trang-viet-tien",
                         SeoDescription = "Áo sơ mi nam trắng Việt Tiến",
                         SeoTitle = "Áo sơ mi nam trắng Việt Tiến",
                         Details = "Áo sơ mi nam trắng Việt Tiến",
                         Description = "Áo sơ mi nam trắng Việt Tiến"
                     },
                    new ProductTranslation()
                    {
                        Id = 8,
                        ProductId = 4,
                        Name = "Viet Tien Men T-Shirt",
                        LanguageId = "en",
                        SeoAlias = "viet-tien-men-t-shirt",
                        SeoDescription = "Viet Tien Men T-Shirt",
                        SeoTitle = "Viet Tien Men T-Shirt",
                        Details = "Viet Tien Men T-Shirt",
                        Description = "Viet Tien Men T-Shirt"
                    },
                     new ProductTranslation()
                     {
                         Id = 9,
                         ProductId = 5,
                         Name = "Áo sơ mi nam trắng Việt Tiến",
                         LanguageId = "vi",
                         SeoAlias = "ao-so-mi-nam-trang-viet-tien",
                         SeoDescription = "Áo sơ mi nam trắng Việt Tiến",
                         SeoTitle = "Áo sơ mi nam trắng Việt Tiến",
                         Details = "Áo sơ mi nam trắng Việt Tiến",
                         Description = "Áo sơ mi nam trắng Việt Tiến"
                     },
                    new ProductTranslation()
                    {
                        Id = 10,
                        ProductId = 5,
                        Name = "Viet Tien Men T-Shirt",
                        LanguageId = "en",
                        SeoAlias = "viet-tien-men-t-shirt",
                        SeoDescription = "Viet Tien Men T-Shirt",
                        SeoTitle = "Viet Tien Men T-Shirt",
                        Details = "Viet Tien Men T-Shirt",
                        Description = "Viet Tien Men T-Shirt"
                    },
                     new ProductTranslation()
                     {
                         Id = 11,
                         ProductId = 6,
                         Name = "Áo sơ mi nam trắng Việt Tiến",
                         LanguageId = "vi",
                         SeoAlias = "ao-so-mi-nam-trang-viet-tien",
                         SeoDescription = "Áo sơ mi nam trắng Việt Tiến",
                         SeoTitle = "Áo sơ mi nam trắng Việt Tiến",
                         Details = "Áo sơ mi nam trắng Việt Tiến",
                         Description = "Áo sơ mi nam trắng Việt Tiến"
                     },
                    new ProductTranslation()
                    {
                        Id = 12,
                        ProductId = 6,
                        Name = "Viet Tien Men T-Shirt",
                        LanguageId = "en",
                        SeoAlias = "viet-tien-men-t-shirt",
                        SeoDescription = "Viet Tien Men T-Shirt",
                        SeoTitle = "Viet Tien Men T-Shirt",
                        Details = "Viet Tien Men T-Shirt",
                        Description = "Viet Tien Men T-Shirt"
                    },
                     new ProductTranslation()
                     {
                         Id = 13,
                         ProductId = 7,
                         Name = "Áo sơ mi nam trắng Việt Tiến",
                         LanguageId = "vi",
                         SeoAlias = "ao-so-mi-nam-trang-viet-tien",
                         SeoDescription = "Áo sơ mi nam trắng Việt Tiến",
                         SeoTitle = "Áo sơ mi nam trắng Việt Tiến",
                         Details = "Áo sơ mi nam trắng Việt Tiến",
                         Description = "Áo sơ mi nam trắng Việt Tiến"
                     },
                    new ProductTranslation()
                    {
                        Id = 14,
                        ProductId = 7,
                        Name = "Viet Tien Men T-Shirt",
                        LanguageId = "en",
                        SeoAlias = "viet-tien-men-t-shirt",
                        SeoDescription = "Viet Tien Men T-Shirt",
                        SeoTitle = "Viet Tien Men T-Shirt",
                        Details = "Viet Tien Men T-Shirt",
                        Description = "Viet Tien Men T-Shirt"
                    },
                     new ProductTranslation()
                     {
                         Id = 15,
                         ProductId = 8,
                         Name = "Áo sơ mi nam trắng Việt Tiến",
                         LanguageId = "vi",
                         SeoAlias = "ao-so-mi-nam-trang-viet-tien",
                         SeoDescription = "Áo sơ mi nam trắng Việt Tiến",
                         SeoTitle = "Áo sơ mi nam trắng Việt Tiến",
                         Details = "Áo sơ mi nam trắng Việt Tiến",
                         Description = "Áo sơ mi nam trắng Việt Tiến"
                     },
                    new ProductTranslation()
                    {
                        Id = 16,
                        ProductId = 8,
                        Name = "Viet Tien Men T-Shirt",
                        LanguageId = "en",
                        SeoAlias = "viet-tien-men-t-shirt",
                        SeoDescription = "Viet Tien Men T-Shirt",
                        SeoTitle = "Viet Tien Men T-Shirt",
                        Details = "Viet Tien Men T-Shirt",
                        Description = "Viet Tien Men T-Shirt"
                    }
                    );
            modelBuilder.Entity<ProductImage>().HasData(
                new ProductImage()
                {
                    Id = 1,
                    ProductId = 1,
                    ImagePath = "/img/product-1.jpg",
                    Caption = "Image",
                    IsDefault = true,
                    DateCreated = DateTime.UtcNow,
                    SortOrder = 1,
                },
                new ProductImage()
                {
                    Id = 2,
                    ProductId = 2,
                    ImagePath = "/img/product-2.jpg",
                    Caption = "Image",
                    IsDefault = true,
                    DateCreated = DateTime.UtcNow,
                    SortOrder = 2,
                },
                new ProductImage()
                {
                    Id = 3,
                    ProductId = 3,
                    ImagePath = "/img/product-3.jpg",
                    Caption = "Image",
                    IsDefault = true,
                    DateCreated = DateTime.UtcNow,
                    SortOrder = 3,
                },
                new ProductImage()
                {
                    Id = 4,
                    ProductId = 4,
                    ImagePath = "/img/product-4.jpg",
                    Caption = "Image",
                    IsDefault = true,
                    DateCreated = DateTime.UtcNow,
                    SortOrder = 4,
                },
                new ProductImage()
                {
                    Id = 5,
                    ProductId = 5,
                    ImagePath = "/img/product-5.jpg",
                    Caption = "Image",
                    IsDefault = true,
                    DateCreated = DateTime.UtcNow,
                    SortOrder = 5,
                },
                new ProductImage()
                {
                    Id = 6,
                    ProductId = 6,
                    ImagePath = "/img/product-6.jpg",
                    Caption = "Image",
                    IsDefault = true,
                    DateCreated = DateTime.UtcNow,
                    SortOrder = 6,
                },
                new ProductImage()
                {
                    Id = 7,
                    ProductId = 7,
                    ImagePath = "/img/product-7.jpg",
                    Caption = "Image",
                    IsDefault = true,
                    DateCreated = DateTime.UtcNow,
                    SortOrder = 7,
                },
                new ProductImage()
                {
                    Id = 8,
                    ProductId = 8,
                    ImagePath = "/img/product-8.jpg",
                    Caption = "Image",
                    IsDefault = true,
                    DateCreated = DateTime.UtcNow,
                    SortOrder = 8,
                }
                );
            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { ProductId = 1, CategoryId = 1 }
                );

            // any guid
            var roleId = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC");
            var adminId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "nghiephm2006@gmail.com",
                NormalizedEmail = "nghiephm2006@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Nghiep13579?"),
                SecurityStamp = string.Empty,
                FirstName = "Nghiep",
                LastName = "Huynh",
                Dob = new DateTime(2000, 06, 20)
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });

            modelBuilder.Entity<Slide>().HasData(
              new Slide() { Id = 1, Name = "Fashionable Dress", Description = "10% Off Your First Order", SortOrder = 1, Url = "#", Image = "/img/carousel-1.jpg", Status = Status.Active },
              new Slide() { Id = 2, Name = "Reasonable Price", Description = "10% Off Your First Order", SortOrder = 2, Url = "#", Image = "/img/carousel-2.jpg", Status = Status.Active }
              );
        }
    }
}