using Business.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes;

public class CarManager : ICarService
{

    private readonly ICarDal _carDal;

    public CarManager(ICarDal carDal)
    {
        _carDal = carDal;
    }

    public List<Car> GetAll()
    {

        return _carDal.GetAll();


    }

    public List<Car> GetCarsByBrandId(int id)
    {
        
        return _carDal.GetAll(o => o.BrandId == id).ToList();

    }

    public List<Car> GetCarsByColorId(int id)
    {
        return _carDal.GetAll(o => o.ColorId == id).ToList();

    }
}
