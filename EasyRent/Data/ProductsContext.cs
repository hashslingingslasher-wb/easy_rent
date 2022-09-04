using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EasyRent.Models;


    public class ProductsContext : DbContext
    {
        public ProductsContext (DbContextOptions<ProductsContext> options)
            : base(options)
            {
        }

        public DbSet<EasyRent.Models.Products> Products { get; set; }
        public DbSet<EasyRent.Models.CartItem> ShoppingCartItems {get; set;}

    }
