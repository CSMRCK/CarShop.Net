using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Whatever.Data.interfaces;
using Whatever.Data.models;

namespace Whatever.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car{ name="Tesla Model S",
                        shortDesc="Some Desc about Tesla",
                        longDesc="Much more info about Tesla car",
                        img="data:image/jpeg;base64,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",
                        price=45000,
                        isFavourite=true,
                        avalible=true,
                        Category = _categoryCars.AllCategories.First()

                    },
                    new Car{ name="Ford Mustang 2020",
                        shortDesc="Some Desc about Mustang",
                        longDesc="Much more info about Tesla Mustang",
                        img="https://img3.akspic.ru/image/38908-zheltyj-sportkar-moshhnye_mashiny-nissan-sportivnyj_avtomobil-1920x1080.jpg",
                        price=23000,
                        isFavourite=true,
                        avalible=true,
                        Category = _categoryCars.AllCategories.First()

                    },
                    new Car{ name="Nissan 370Z",
                        shortDesc="Some Desc about Nissan",
                        longDesc="Much more info about Nissan car",
                        img="https://img3.akspic.ru/image/38908-zheltyj-sportkar-moshhnye_mashiny-nissan-sportivnyj_avtomobil-1920x1080.jpg",
                        price=26000,
                        isFavourite=true,
                        avalible=true,
                        Category = _categoryCars.AllCategories.First()

                    },
                    new Car{ name="Nissan 370Z",
                        shortDesc="Some Desc about Nissan",
                        longDesc="Much more info about Nissan car",
                        img="https://img3.akspic.ru/image/38908-zheltyj-sportkar-moshhnye_mashiny-nissan-sportivnyj_avtomobil-1920x1080.jpg",
                        price=26000,
                        isFavourite=true,
                        avalible=true,
                        Category = _categoryCars.AllCategories.First()

                    },
                    new Car{ name="Nissan 370Z",
                        shortDesc="Some Desc about Nissan",
                        longDesc="Much more info about Nissan car",
                        img="https://img3.akspic.ru/image/38908-zheltyj-sportkar-moshhnye_mashiny-nissan-sportivnyj_avtomobil-1920x1080.jpg",
                        price=26000,
                        isFavourite=true,
                        avalible=true,
                        Category = _categoryCars.AllCategories.First()

                    },
                    new Car{ name="Nissan 370Z",
                        shortDesc="Some Desc about Nissan",
                        longDesc="Much more info about Nissan car",
                        img="https://img3.akspic.ru/image/38908-zheltyj-sportkar-moshhnye_mashiny-nissan-sportivnyj_avtomobil-1920x1080.jpg",
                        price=26000,
                        isFavourite=true,
                        avalible=true,
                        Category = _categoryCars.AllCategories.First()

                    }
                };
            }
        }
        public IEnumerable<Car> getFavCars
        {
            get;
        }

        public Car getObjectCar(int carid)
        {
            throw new NotImplementedException();
        }
    }
}
