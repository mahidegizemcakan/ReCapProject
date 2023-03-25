using DataAccess.Abstract;
using Entitiess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrate.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car car)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car car)
        {
            throw new NotImplementedException();
        }

        public List<Car> GelAll()
        {
            return new List<Car> { new Car { Description="Mercedes"}, new Car { Description = "polo" }, new Car { Description = "Charolet" } };
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
