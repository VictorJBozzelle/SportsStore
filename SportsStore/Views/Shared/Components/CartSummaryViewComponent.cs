using System;
using System.Linq;
using SportsStore.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace SportsStore.Views.Shared.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private Cart cart;
        public CartSummaryViewComponent(Cart cartService)
        {
            cart=cartService;
        }
        public IViewComponentResult Invoke()
        {
            return View(cart);
        }
    }
}
