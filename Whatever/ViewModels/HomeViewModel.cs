using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Whatever.Data.models;

namespace Whatever.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Car> favCars
        {
            get;set;
        }
    }
}
