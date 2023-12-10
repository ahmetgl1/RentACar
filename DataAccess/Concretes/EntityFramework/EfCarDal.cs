using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework.Context;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework;

public class EfCarDal : ICarDal
{
    public void Add(Car entity)
    {
       
        using(AppDbContext context = new AppDbContext())
        {

             context.Add<Car>(entity);
            context.SaveChanges();
        }

    }

    public void Delete(Car entity)
    {
        using (AppDbContext context = new AppDbContext())
        {

            var deletedEntity = context.Remove(entity);
            deletedEntity.State = EntityState.Deleted;
            context.SaveChanges();

        }

    }

    public Car Get(Expression<Func<Car, bool>> filter)
    {

        using (AppDbContext context = new AppDbContext())
        {

            Car car = context.Set<Car>().SingleOrDefault();
            if(car is null)
            {
                throw new Exception("Bulunamadı");
            }

        return car;
        }
    }

    public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
    {

        using (AppDbContext context = new AppDbContext())
        {

           return filter == null ?  context.Set<Car>().ToList() 
                : 
                context.Set<Car>().Where(filter).ToList();

        }




    }

    public void Update(Car entity)
    {
        using (AppDbContext context = new AppDbContext())
        {

            var updatedEntity = context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            context.SaveChanges();

        }
    }
}
