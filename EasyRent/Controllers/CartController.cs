using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EasyRent.Models;

namespace EasyRent.Controllers
{
    public class CartController : Controller, IDisposable 
    {
        public string CartId { get; set; }
        private readonly ProductsContext _context;

        public ProductsController(ProductsContext context)
        {
            _context = context;
        }
        public void AddToCart(int id){
            var cartItem = _context.Products.Find()
        }

       
    }
}