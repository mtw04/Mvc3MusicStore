using System.Collections.Generic;
using Mvc3MusicStore.Models;

namespace Mvc3MusicStore.ViewModels
{
    public class ShoppingCartViewModel
    {
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}