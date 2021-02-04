using ReCapProject.Entities.Concrete;
using System.Collections.Generic;

namespace ReCapProject.Business.Concrete
{
    public interface ICarManager
    {
        List<Car> GetAll();
        List<Car> GetByBrandId(int brandId);
        List<Car> GetByColorId(int colorId);
    }
}