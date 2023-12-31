﻿using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts;

public interface ICarService 
{

    List<Car> GetAll();

    List<Car> GetCarsByBrandId(int id);
    List<Car> GetCarsByColorId(int id);



}
