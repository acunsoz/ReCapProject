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
                new Car{Id=1,BrandId=1,CarName="Mercedes",ColorId=1,ModelYear="2010",DailyPrice=200000,Description="Mercedes C180" },
                new Car{Id=2,BrandId=2,ColorId=2,CarName="Volkswagen",ModelYear="2016",DailyPrice=248000,Description="Volkswagen Passat" },
                new Car{Id=3,BrandId=2,ColorId=2,CarName="Volkswagen",ModelYear="2013",DailyPrice=390000,Description="Volkswagen Caddy" },
                new Car{Id=4,BrandId=3,ColorId=3,CarName="Renault",ModelYear="2017",DailyPrice=165000,Description="Renault Clio" },
                new Car{Id=5,BrandId=4,ColorId=1,CarName="Chevrolet",ModelYear="2013",DailyPrice=560000,Description="Chevrolet Camaro" }
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

        public List<Car> GetAll(Expression<Func<Car, bool>> fiter = null)
        {
            return _cars;
        }


        public Car GetById(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.CarName = car.CarName;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
