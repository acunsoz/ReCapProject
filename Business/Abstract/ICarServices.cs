using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarServices
    {
        List<Car> GetAll();
        List<Car> GetCarsBrandId();
        List<Car> GetCarsColorId();
        void Add(Car car);
        
    }
}
