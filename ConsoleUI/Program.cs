using Buisness.Concrete;
using DataAccess.Concrate.EntityFramework;
using DataAccess.Concrate.InMemory;
using Entitiess.Concrete;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

        }
    }
}
