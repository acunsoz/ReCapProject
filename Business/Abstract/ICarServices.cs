using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarServices
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarsBrandId(int brandId);
        IDataResult<List<Car>> GetCarsColorId(int colorId);
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        
    }
}
