using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorServices
    {
        void Add(Color color);
        void Delete(Color color);
        void Update(Color color);
        List<Color> GetAll();
    }
}
