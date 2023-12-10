using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.InMemory;

public class InMemoryCarDal : ICarDal
{
    List<Car> _cars = new List<Car>
{
    new Car
    {
        Id = 1,
        BrandId = 1,
        ColorId = 1,
        ModelYear = 2023,
        DailyPrice = 0,
        Description = "Car 1"
    },
    new Car
    {
        Id = 2,
        BrandId = 1,
        ColorId = 1,
        ModelYear = 2027,
        DailyPrice = 0,
        Description = "Car 2"
    },
    new Car
    {
        Id = 3,
        BrandId = 1,
        ColorId = 1,
        ModelYear = 2030,
        DailyPrice = 0,
        Description = "Car 3"
    },
    new Car
    {
        Id = 4,
        BrandId = 1,
        ColorId = 1,
        ModelYear = 2035,
        DailyPrice = 0,
        Description = "Car 4"
    },
    new Car
    {
        Id = 5,
        BrandId = 1,
        ColorId = 1,
        ModelYear = 2032,
        DailyPrice = 0,
        Description = "Car 5"
    },
    new Car
    {
        Id = 6,
        BrandId = 1,
        ColorId = 1,
        ModelYear = 2038,
        DailyPrice = 0,
        Description = "Car 6"
    },
    new Car
    {
        Id = 7,
        BrandId = 1,
        ColorId = 1,
        ModelYear = 2025,
        DailyPrice = 0,
        Description = "Car 7"
    },
    new Car
    {
        Id = 8,
        BrandId = 1,
        ColorId = 1,
        ModelYear = 2040,
        DailyPrice = 0,
        Description = "Car 8"
    },
    new Car
    {
        Id = 9,
        BrandId = 1,
        ColorId = 1,
        ModelYear = 2037,
        DailyPrice = 0,
        Description = "Car 9"
    },
    new Car
    {
        Id = 10,
        BrandId = 1,
        ColorId = 1,
        ModelYear = 2026,
        DailyPrice = 0,
        Description = "Car 10"
    }
};





    public void Add(Car car)
    {
        
        _cars.Add(car);


    }

    public void Delete(Car car)
    {


        var deletedCar = _cars.FirstOrDefault(p => p.Id == car.Id);
        if (deletedCar is null)
        {
            throw new Exception("Araç Bulunamadı ");
        }
        _cars.Remove(deletedCar);



    }

    public List<Car> GetAll()
    {


        return _cars;
    }

    public Car GetById(int id)
    {

        Car car = _cars.FirstOrDefault(o => o.Id == id);


        if(car is null)
        {
            throw new Exception("Araba bulunamadı!");

        }

        return car;

    }

    public void Update(Car car)
    {

        Car updatedCar = _cars.FirstOrDefault(o => o.Id == car.Id);
        if (updatedCar is null)
        {
            throw new Exception("araç bulunamadı !");
            
        }
        updatedCar.DailyPrice = car.DailyPrice;
        updatedCar.Description = car.Description;
        updatedCar.ModelYear = car.ModelYear;


    }
}
