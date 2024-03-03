using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DataAccess
{
    public class GenerateFakeData
    {
        public static async Task SeedDataAsync(EFcoreContext context, ILoggerFactory loggerFactory)
        {
			try
			{
                if (!await context.ProductBrands.AnyAsync())
                {
                    var productPrands = ProductBrands();
                    await context.ProductBrands.AddRangeAsync(productPrands);
                    context.SaveChanges();
                }
                if (!await context.ProductTypes.AnyAsync())
                {
                    var productTypes = ProductTypes();
                    await context.ProductTypes.AddRangeAsync(productTypes);
                    context.SaveChanges();
                }
                if (!await context.Products.AnyAsync())
                {
                    var producs = Products();
                    await context.Products.AddRangeAsync(producs);
                    context.SaveChanges();
                }
            }
			catch (Exception exp)
			{
                var logger = loggerFactory.CreateLogger<GenerateFakeData>();
                logger.LogError(exp, "seed data error.");
			}
        }

        private static List<ProductBrand> ProductBrands()
        {
            var brands = new List<ProductBrand>()
        {
            new()
            {
                Description =
                    "Fugiat ad culpa ad dolor est tempor esse deserunt amet duis. Amet nulla esse voluptate non voluptate. Minim irure ea tempor et mollit aute consectetur. Esse amet commodo ipsum magna. Enim non nostrud minim dolore minim deserunt consequat deserunt deserunt sint amet. Ex aliquip nisi ullamco qui.\r\n",
                Summary =
                    "Fugiat ad culpa ad dolor est tempor esse deserunt amet duis. Amet nulla esse voluptate ",
                Title = "brand1",
            },
            new()
            {
                Description =
                    "Fugiat ad culpa ad dolor est tempor esse deserunt amet duis. Amet nulla esse voluptate non voluptate. Minim irure ea tempor et mollit aute consectetur. Esse amet commodo ipsum magna. Enim non nostrud minim dolore minim deserunt consequat deserunt deserunt sint amet. Ex aliquip nisi ullamco qui.\r\n",
                Summary =
                    "Fugiat ad culpa ad dolor est tempor esse deserunt amet duis. Amet nulla esse voluptate ",
                Title = "brand2",
            }
        };
            return brands;
        }

        private static List<ProductType> ProductTypes()
        {
            var types = new List<ProductType>()
        {
            new()
            {
                Description =
                    "Fugiat ad culpa ad dolor est tempor esse deserunt amet duis. Amet nulla esse voluptate non voluptate. Minim irure ea tempor et mollit aute consectetur. Esse amet commodo ipsum magna. Enim non nostrud minim dolore minim deserunt consequat deserunt deserunt sint amet. Ex aliquip nisi ullamco qui.\r\n",
                Summary =
                    "Fugiat ad culpa ad dolor est tempor esse deserunt amet duis. Amet nulla esse voluptate ",
                Title = "brand1",
            },
            new()
            {
                Description =
                    "Fugiat ad culpa ad dolor est tempor esse deserunt amet duis. Amet nulla esse voluptate non voluptate. Minim irure ea tempor et mollit aute consectetur. Esse amet commodo ipsum magna. Enim non nostrud minim dolore minim deserunt consequat deserunt deserunt sint amet. Ex aliquip nisi ullamco qui.\r\n",
                Summary =
                    "Fugiat ad culpa ad dolor est tempor esse deserunt amet duis. Amet nulla esse voluptate ",
                Title = "brand2",
            }
        };
            return types;
        }

        private static IEnumerable<Product> Products()
        {
            var products = new List<Product>()
        {
            new()
            {
                Description =
                    "Fugiat ad culpa ad dolor est tempor esse deserunt amet duis. Amet nulla esse voluptate non voluptate. Minim irure ea tempor et mollit aute consectetur. Esse amet commodo ipsum magna. Enim non nostrud minim dolore minim deserunt consequat deserunt deserunt sint amet. Ex aliquip nisi ullamco qui.\r\n",
                Summary = "Velit ea do est et et irure magna. Fugiat sit proident do irure nisi cupidatat",
                PictureUrl = "image.jpeg",
                Price = 15000,
                Title = "product 1",
                ProductBrandId = 1,
                ProductTypeId = 1,
            },
            new()
            {
                Description =
                    "Fugiat ad culpa ad dolor est tempor esse deserunt amet duis. Amet nulla esse voluptate non voluptate. Minim irure ea tempor et mollit aute consectetur. Esse amet commodo ipsum magna. Enim non nostrud minim dolore minim deserunt consequat deserunt deserunt sint amet. Ex aliquip nisi ullamco qui.\r\n",
                Summary = "Velit ea do est et et irure magna. Fugiat sit proident do irure nisi cupidatat",
                PictureUrl = "image.jpeg",
                Price = 15000,
                Title = "product 2",
                ProductBrandId = 1,
                ProductTypeId = 1,
            },
            new()
            {
                Description =
                    "Fugiat ad culpa ad dolor est tempor esse deserunt amet duis. Amet nulla esse voluptate non voluptate. Minim irure ea tempor et mollit aute consectetur. Esse amet commodo ipsum magna. Enim non nostrud minim dolore minim deserunt consequat deserunt deserunt sint amet. Ex aliquip nisi ullamco qui.\r\n",
                Summary = "Velit ea do est et et irure magna. Fugiat sit proident do irure nisi cupidatat",
                PictureUrl = "image.jpeg",
                Price = 15000,
                Title = "product 3",
                ProductBrandId = 1,
                ProductTypeId = 1,
            },
            new()
            {
                Description =
                    "Fugiat ad culpa ad dolor est tempor esse deserunt amet duis. Amet nulla esse voluptate non voluptate. Minim irure ea tempor et mollit aute consectetur. Esse amet commodo ipsum magna. Enim non nostrud minim dolore minim deserunt consequat deserunt deserunt sint amet. Ex aliquip nisi ullamco qui.\r\n",
                Summary = "Velit ea do est et et irure magna. Fugiat sit proident do irure nisi cupidatat",
                PictureUrl = "image.jpeg",
                Price = 15000,
                Title = "product 1",
                ProductBrandId = 1,
                ProductTypeId = 1,
            },
            new()
            {
                Description =
                    "Fugiat ad culpa ad dolor est tempor esse deserunt amet duis. Amet nulla esse voluptate non voluptate. Minim irure ea tempor et mollit aute consectetur. Esse amet commodo ipsum magna. Enim non nostrud minim dolore minim deserunt consequat deserunt deserunt sint amet. Ex aliquip nisi ullamco qui.\r\n",
                Summary = "Velit ea do est et et irure magna. Fugiat sit proident do irure nisi cupidatat",
                PictureUrl = "image.jpeg",
                Price = 15000,
                Title = "product 1",
                ProductBrandId = 1,
                ProductTypeId = 1,
            },
            new()
            {
                Description =
                    "Fugiat ad culpa ad dolor est tempor esse deserunt amet duis. Amet nulla esse voluptate non voluptate. Minim irure ea tempor et mollit aute consectetur. Esse amet commodo ipsum magna. Enim non nostrud minim dolore minim deserunt consequat deserunt deserunt sint amet. Ex aliquip nisi ullamco qui.\r\n",
                Summary = "Velit ea do est et et irure magna. Fugiat sit proident do irure nisi cupidatat",
                PictureUrl = "image.jpeg",
                Price = 15000,
                Title = "product 1",
                ProductBrandId = 1,
                ProductTypeId = 1,
            },
            new()
            {
                Description =
                    "Fugiat ad culpa ad dolor est tempor esse deserunt amet duis. Amet nulla esse voluptate non voluptate. Minim irure ea tempor et mollit aute consectetur. Esse amet commodo ipsum magna. Enim non nostrud minim dolore minim deserunt consequat deserunt deserunt sint amet. Ex aliquip nisi ullamco qui.\r\n",
                Summary = "Velit ea do est et et irure magna. Fugiat sit proident do irure nisi cupidatat",
                PictureUrl = "image.jpeg",
                Price = 15000,
                Title = "product 1",
                ProductBrandId = 1,
                ProductTypeId = 1,
            },
            new()
            {
                Description =
                    "Fugiat ad culpa ad dolor est tempor esse deserunt amet duis. Amet nulla esse voluptate non voluptate. Minim irure ea tempor et mollit aute consectetur. Esse amet commodo ipsum magna. Enim non nostrud minim dolore minim deserunt consequat deserunt deserunt sint amet. Ex aliquip nisi ullamco qui.\r\n",
                Summary = "Velit ea do est et et irure magna. Fugiat sit proident do irure nisi cupidatat",
                PictureUrl = "image.jpeg",
                Price = 15000,
                Title = "product 1",
                ProductBrandId = 1,
                ProductTypeId = 1,
            },
            new()
            {
                Description =
                    "Fugiat ad culpa ad dolor est tempor esse deserunt amet duis. Amet nulla esse voluptate non voluptate. Minim irure ea tempor et mollit aute consectetur. Esse amet commodo ipsum magna. Enim non nostrud minim dolore minim deserunt consequat deserunt deserunt sint amet. Ex aliquip nisi ullamco qui.\r\n",
                Summary = "Velit ea do est et et irure magna. Fugiat sit proident do irure nisi cupidatat",
                PictureUrl = "image.jpeg",
                Price = 15000,
                Title = "product 1",
                ProductBrandId = 1,
                ProductTypeId = 1,
            },
            new()
            {
                Description =
                    "Fugiat ad culpa ad dolor est tempor esse deserunt amet duis. Amet nulla esse voluptate non voluptate. Minim irure ea tempor et mollit aute consectetur. Esse amet commodo ipsum magna. Enim non nostrud minim dolore minim deserunt consequat deserunt deserunt sint amet. Ex aliquip nisi ullamco qui.\r\n",
                Summary = "Velit ea do est et et irure magna. Fugiat sit proident do irure nisi cupidatat",
                PictureUrl = "image.jpeg",
                Price = 15000,
                Title = "product 1",
                ProductBrandId = 1,
                ProductTypeId = 1,
            }
        };
            return products;
        }
    }
}
