using Microsoft.AspNetCore.Mvc;
using SklepInternetowy.Data.Intefaces;
using SklepInternetowy.Data.Models;
using SklepInternetowy.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SklepInternetowy.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCat)
        {
            _allCars = iAllCars;
            _allCategories = iCarsCat;
        }
        [Route("Cars/List")]
        [Route("Cars/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Car> cars = null;
            string currCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                cars = _allCars.Cars.OrderBy(i => i.id);
            }
            else
            {
                if(string.Equals("electro", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Elektryczne samochody")).OrderBy(i => i.id);
                    currCategory = "Elektryczne samochody";
                }
                else if(string.Equals("fuel", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Zwykłe samochody")).OrderBy(i => i.id);
                    currCategory = "Zwykłe samochody";
                }
            }
            
            var carObj = new CarsListViewModel
                {
                    allCars = cars,
                    currCategory = currCategory
                };

            ViewBag.Title = "Strona z samochodami";
            
            return View(carObj);
        }
    }
}
