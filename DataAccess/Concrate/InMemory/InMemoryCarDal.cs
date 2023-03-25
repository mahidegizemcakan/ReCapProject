using DataAccess.Abstract;
using Entitiess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrate.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars= new List<Car>
            {
                new Car{ CarId=1,BrandId=1, ColorId=1, ModelYear=2023, DailyPrice=1000000, Description="Mercedes"},
                new Car{ CarId=2,BrandId=2, ColorId=1, ModelYear=2023, DailyPrice=1000000, Description="Bmw"},
                new Car{ CarId=2,BrandId=3, ColorId=1, ModelYear=2023, DailyPrice=1000000, Description="Volvo"},
                new Car{ CarId=2,BrandId=4, ColorId=1, ModelYear=2023, DailyPrice=1000000, Description="Volkvogen"},
                new Car{ CarId=2,BrandId=5, ColorId=1, ModelYear=2023, DailyPrice=1000000, Description="Ferrari"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;
            carToDelete =_cars.SingleOrDefault(x => x.CarId == car.CarId);
            _cars.Remove(car);
        }

        public List<Car> GelAll()
        {
            return _cars;
        }

        public void Update(Car car)
        {
            Car carToUpdate= _cars.SingleOrDefault(x =>x.CarId == car.CarId);
            carToUpdate.BrandId= car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            
        }
    }
}
