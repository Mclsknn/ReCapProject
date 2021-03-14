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
             carDetailsTest();
           // Car newCar = new Car {
           //     CarId = 10, CarName = "Ferrari", BrandId =13, ColorId= 10, DailyPrice =150 , Description="" , ModelYear=2010 };
           // CarManager carManager = new CarManager(new EfCarDal());
           // carManager.Add(newCar);
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

        private static void carDetailsTest()
        { 
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine("{0}--{1}--{2}--{3}", car.CarName, car.BrandName, car.ColorName, car.DailyPrice);
                }
            }
            else {
                Console.WriteLine(result.Message);
            }
           
        }
    }
}
