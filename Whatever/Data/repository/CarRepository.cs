using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Whatever.Data.interfaces;
using Whatever.Data.models;


namespace Whatever.Data.repository
{
    public class CarRepository : IAllCars
    {
        private readonly AppDbContent appDbContent;

        public CarRepository(AppDbContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }
        public IEnumerable<Category> AllCategories => throw new NotImplementedException();

        public IEnumerable<Car> Cars => appDbContent.Car.Include(c=>c.Category);

        public IEnumerable<Car> getFavCars => appDbContent.Car.Where(p => p.isFavourite)
            .Include(c => c.Category);
        public Car getObjectCar(int carId) => appDbContent.Car
            .FirstOrDefault(p=>p.id==carId);
    }
}
