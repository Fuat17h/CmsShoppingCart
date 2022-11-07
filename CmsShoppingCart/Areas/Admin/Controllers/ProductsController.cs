﻿using CmsShoppingCart.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace CmsShoppingCart.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductsController : Controller
    {
        private readonly CmsShoppingCartContext context;

        public ProductsController(CmsShoppingCartContext context)
        {
            this.context = context;
        }
        //GET  /admin/products
        public async Task<IActionResult> Index()
        {

            return View(await context.Products.OrderByDescending(x => x.Id).Include(x => x.category).ToListAsync());
        }
    }
}
