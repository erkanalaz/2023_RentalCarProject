using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //AllOldRecords();

            CarManager carManager=new CarManager(new EfCarDal());
            foreach (var item in carManager.GetCarDetails())
            {
                Console.WriteLine(item.CarName+" "+item.BrandName+" "+item.ColorName+" "+item.DailyPrice);
            }
        }

        private static void AllOldRecords()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            Console.WriteLine("-------------------------------");

            carManager.Add(new Car
            {
                BrandId = 3,
                ColorId = 4,
                ModelYear = "2023",
                DailyPrice = 330,
                Description = "BEYAZ AUDİ A3"
            });

            Console.WriteLine("-------------------------------");


            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("-------------------------------");

            foreach (var car in carManager.GetCarsByColorId(1))
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("-------------------------------");

            foreach (var car in carManager.GetGetCarsByBrandId(2))
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("-------------------------------");

            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.Name);
            }
        }
    }
}
