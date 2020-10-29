using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChocolateShop.Models;
using ChocolateShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ChocolateShop.Controllers
{
    public class ChocolateController : Controller
    {
        private readonly IChocolateRepository _chocolateRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ChocolateController(IChocolateRepository chocolateRepository, ICategoryRepository categoryRepository)
        {
            _chocolateRepository = chocolateRepository;
            _categoryRepository = categoryRepository;
        }

       public IActionResult List()
        {
            //ViewBag.CurrentCategory = "Bestsellers";
            //return View(_chocolateRepository.GetChocolates);

            var ChocolateListViewModel = new ChocolateListViewModel();
            ChocolateListViewModel.Chocolates = _chocolateRepository.GetChocolates;
            ChocolateListViewModel.CurrentCategory = "Bestsellers";
            return View(ChocolateListViewModel);
        }



    }
    
    

}
