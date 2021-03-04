using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("{0}--{1}--{2}--{3}--{4}--{5}",car.CarId,car.CarName,car.BrandId,car.ColorId,car.DailyPrice,car.Description);
            }
            //CarManager carManager = new CarManager(new InMemoryCarDal());
            //foreach (var car in carManager.GetAll())
            //{
             //   Console.WriteLine(car.Description);
            //}
           // Car carr = new Car();
           // carr = carManager.GetById(2);
           //Console.WriteLine(carr.ModelYear);
           // carManager.Add(carr);
           // carr.ModelYear = 2020;
           // carr.Description = "E Kalite araba";
           // carManager.Update(carr);
           // Console.WriteLine(carr.ModelYear);
           // carManager.Delete(carr);
           // foreach (var car in carManager.GetAll())
           // {
            //    Console.WriteLine(car.Description);
            //}
            
        }
    }
}
