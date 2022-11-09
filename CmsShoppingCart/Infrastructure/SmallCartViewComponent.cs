﻿using CmsShoppingCart.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CmsShoppingCart.Infrastructure
{
    public class SmallCartViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            List<CartItem> cart = HttpContext.Session.GetJson<List<CartItem>>("Cart");
            SmallCartViewModel smallCartVM;

            if (cart == null || cart.Count == 0)
            {
                smallCartVM = null;
            }
            else
            {
                smallCartVM = new SmallCartViewModel
                {
                    NumberOfItems = cart.Sum(x => x.Quantity),
                    TotalAmount = cart.Sum(x => x.Quantity * x.Price)
                };
            }

            return View(smallCartVM);
        }
    }
}
