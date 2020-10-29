using ChocolateShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChocolateShop.ViewModels
{
    public class ChocolateListViewModel
    {
        public IEnumerable<Chocolate> Chocolates { get; set; }
        public string CurrentCategory { get; set; }
    }
}
