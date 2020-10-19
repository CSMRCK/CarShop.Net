using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Whatever.Data.models;

namespace Whatever.Data.interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> getFavCars { get; }
        Car getObjectCar(int carid);
    }
}
