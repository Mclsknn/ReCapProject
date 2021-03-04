﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
   public interface ICarDal:IEntityRepository<Car>
    {
        List<Car> GetCarsByBrandId(int Id);
        List<Car> GetCarsByColorId(int Id);
    }
}
