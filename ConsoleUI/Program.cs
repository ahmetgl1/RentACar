using Business.Concretes;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CarManager manager = new CarManager(new EfCarDal());

            foreach (var car in manager.GetCarsByBrandId(3))
            {

                Console.WriteLine(car.Id);


            }


        }
    }
}