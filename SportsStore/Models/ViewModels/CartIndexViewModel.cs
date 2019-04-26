using System;
using System.Linq;
using SportsStore.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace SportsStore.Models.ViewModels
{
    public class CartIndexViewModel
    {
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
    }
}
