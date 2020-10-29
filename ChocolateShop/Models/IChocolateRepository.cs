using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChocolateShop.Models
{
    public interface IChocolateRepository
    {
        IEnumerable<Chocolate> GetChocolates { get; }
        IEnumerable<Chocolate> GetChocolatesOnSale { get; }
        Chocolate GetChocolateById(int ChocolateId);
    }
}
