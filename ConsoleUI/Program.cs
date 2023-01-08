using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Storage;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //AllOldRecords();

            CarManager carManager=new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.CarName + " " + item.BrandName + " " + item.ColorName + " " + item.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }

       
    }
}
