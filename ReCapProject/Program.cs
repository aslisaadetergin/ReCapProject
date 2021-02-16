using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ReCapProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id);
            }


            carManager.Add(new Car
            {
                Id = 2,
                BrandId = "10",
                ColorId = "8",
                ModelYear = "2019",
                DailyPrice = "125",
                Description = "2019 model bir araba"
            });
        }
    }
}
