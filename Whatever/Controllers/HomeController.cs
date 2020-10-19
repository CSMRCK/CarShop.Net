using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Whatever.Data.interfaces;
using Whatever.ViewModels;

namespace Whatever.Controllers
{
    public class HomeController : Controller
    {
        private  IAllCars _carRep;


        public HomeController(IAllCars carRep)
        {
            _carRep = carRep;
        }

        public ViewResult index()
        {
            var homeCars = new HomeViewModel
            {
                favCars = _carRep.getFavCars
            };
            return View(homeCars);
        }

    }
}
