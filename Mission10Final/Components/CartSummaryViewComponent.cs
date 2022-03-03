using System;
using Microsoft.AspNetCore.Mvc;
using Mission10Final.Models;

namespace Mission10Final.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private Basket repo;

        public CartSummaryViewComponent(Basket temp)
        {
            repo = temp;
        }

        public IViewComponentResult Invoke()
        {
            // Show Cart summary
            return View(repo);
        }
    }
}
