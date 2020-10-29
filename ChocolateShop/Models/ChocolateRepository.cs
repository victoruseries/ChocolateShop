using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChocolateShop.Models
{
    public class ChocolateRepository : IChocolateRepository
    {
        private readonly AppDbContext _appDbContext;
        public ChocolateRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Chocolate> GetChocolates
        { 
           get
            {
                return _appDbContext.Chocolates.Include(c => c.Category);
            }
            
     
          

        }

        public IEnumerable<Chocolate> GetChocolatesOnSale
        {
            get
            {
                return _appDbContext.Chocolates.Include(c => c.Category).Where(p => p.IsOnSale);
            }
        }

        public Chocolate GetChocolateById(int ChocolateId)
        {
            return _appDbContext.Chocolates.FirstOrDefault(c => c.ChocolateId == ChocolateId);
        }
    }
}
