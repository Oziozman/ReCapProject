﻿using ReCapProject.Business;
using ReCapProject.DataAccess.Abstract;
using ReCapProject.DataAccess.Concrete;
using ReCapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetByBrandId(int brandId)
        {
            return _carDal.GetByBrandId(brandId);
        }

        public List<Car> GetByColorId(int colorId)
        {
            return _carDal.GetByColorId(colorId);
        }


    }
}


