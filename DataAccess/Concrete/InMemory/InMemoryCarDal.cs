using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{Id=1,BrandId=1,ColorId="Siyah",ModelYear="2010",DailyPrice=200000,Description="Mercedes C180" },
                new Car{Id=2,BrandId=2,ColorId="Beyaz",ModelYear="2016",DailyPrice=248000,Description="Volkswagen Passat" },
                new Car{Id=3,BrandId=2,ColorId="Lacivert",ModelYear="2013",DailyPrice=390000,Description="Volkswagen Caddy" },
                new Car{Id=4,BrandId=3,ColorId="Gri",ModelYear="2017",DailyPrice=165000,Description="Renault Clio" },
                new Car{Id=5,BrandId=4,ColorId="Siyah",ModelYear="2013",DailyPrice=560000,Description="Chevrolet Camaro" }
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
