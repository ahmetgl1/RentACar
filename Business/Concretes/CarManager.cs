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

    public void AddCar(Car car)
    {
        if (car.Name.Length < 2)
        {
            throw new Exception("Araba ismi minimum 2 karakter olmalıdır.");
        }

        if (car.DailyPrice <= 0)
        {
            throw new Exception("Araba günlük fiyatı 0'dan büyük olmalıdır.");
        }

        _carDal.Add(car);
    }
}
