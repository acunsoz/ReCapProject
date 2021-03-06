using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarServices
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.CarName.Length < 2 && car.DailyPrice < 0)
            {
                _carDal.Add(car);
            }
            else
            {
                Console.WriteLine("Arabanın adı 2 harften küçükse ve fiyatı 0 dan küçükse eklenemez.");
            }
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsBrandId()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsColorId()
        {
            throw new NotImplementedException();
        }
    }
}
