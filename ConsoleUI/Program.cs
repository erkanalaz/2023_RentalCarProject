using System;
using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager=new CarManager(new InMemoryCarDal());

            
            Console.WriteLine("------------------------------------");

            foreach (var item in carManager.GetById(1))
            {
                Console.WriteLine(item.Description);
            }

            Console.WriteLine("------------------------------------");

            carManager.Add(new Car
            {
                Id = 6,BrandId = 2,ColorId = 3,DailyPrice = 350,ModelYear = "2020",Description = "Yeni eklenen araç"
            });
            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.Description);
            }

            Console.WriteLine("------------------------------------");

            //carManager.Delete(new Car
            //{
            //    Id = 6,
            //    BrandId = 2,
            //    ColorId = 3,
            //    DailyPrice = 350,
            //    ModelYear = "2020",
            //    Description = "Yeni eklenen araç"

            //});

            //foreach (var item in carManager.GetAll())
            //{
            //    Console.WriteLine(item.Description);
            //}

            Console.WriteLine("------------------------------------");

            carManager.Update(new Car
            {
                Id = 6,
                BrandId = 2,
                ColorId = 3,
                DailyPrice = 350,
                ModelYear = "2020",
                Description = "Güncellenen araç"
            });

            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.Description);
            }
        }
    }
}
