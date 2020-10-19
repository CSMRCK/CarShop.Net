using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Whatever.Data.interfaces;
using Whatever.Data.models;
using Whatever.ViewModels;

namespace Whatever.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly IAllCars _allCategories;

        public CarsController(IAllCars iAllCars, IAllCars iCarsCategory)
        {
            _allCars = iAllCars;
            _allCategories = iCarsCategory;
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
                if (string.Equals("Electrocars", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName
                    .Equals("Electrocars")).OrderBy(i => i.id);

                }
                else if (string.Equals("Musclecars", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName
                    .Equals("Musclecars")).OrderBy(i => i.id);

                }

                currCategory = _category;
            }

            var carObj = new CarsListViewModel
            {
                allCars = cars,
                currCategory = currCategory
        };


        ViewBag.Title = "Page with cars";


            return View(carObj);
        }
    }
}
