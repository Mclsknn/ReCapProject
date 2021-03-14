using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
            new Car {CarId = 1, BrandId=1000, ColorId=100, DailyPrice=150,Description="D kalite araba", ModelYear=2009},
            new Car {CarId = 2, BrandId=1001, ColorId=101, DailyPrice=200,Description="C kalite araba", ModelYear=2011},
            new Car {CarId = 3, BrandId=1002, ColorId=100, DailyPrice=250,Description="B kalite araba", ModelYear=2014},
            new Car {CarId = 4, BrandId=1003, ColorId=103, DailyPrice=300,Description="A kalite araba", ModelYear=2019},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
            Console.WriteLine("Araba eklendi");
        }

        public void Delete(Car car)
        {
            Car carToDelete;
            carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId); //First FirstOrDefault
            _cars.Remove(carToDelete);
            Console.WriteLine("Araba silindi");
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int Id)
        {
            Car carToIdReturn = _cars.SingleOrDefault(c => c.CarId == Id);
            return carToIdReturn;
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByBrandId(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByColorId(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {   //Listedeki gönderilen id ye sahip ürünü bul
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
            Console.WriteLine("Araba güncellendi");
            
        }
    }
}
