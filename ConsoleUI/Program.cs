using System;
using Business.Concrete;
using Business.Constants;
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
            UserManager userManager = new UserManager(new EfUserDal());
            BrandManager brandManager=new BrandManager(new EfBrandDal());
            ColorManager colorManager= new ColorManager(new EfColorDal());
            RentalManager rentalManager= new RentalManager(new EfRentalDal());
            //UserAdd(userManager);
            //UserGetAll(userManager);

            //BrandAdd(brandManager);
            //BrandGetAll(brandManager);

            //ColorAdd(colorManager);
            //ColorGetAll(colorManager);

            RentalAdd(rentalManager);
            //RentalGetAll(rentalManager);
        }

        private static void RentalAdd(RentalManager rentalManager)
        {
            rentalManager.Add(new Rental
            {
                CarId = 1, CustomerId = 1, RentDate = DateTime.Now, ReturnDate = DateTime.MinValue}
            );

        }

        private static void RentalGetAll(RentalManager rentalManager)
        {
            var result = rentalManager.GetAll();
            if (result.Success)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.Id + " " + item.CarId + " " + item.CustomerId + " " + item.RentDate + " " +
                                      item.ReturnDate);
                }
            }

            Console.WriteLine(result.Message);
        }

        private static void ColorAdd(ColorManager colorManager)
        {
            colorManager.Add(new Color {Name = "Sarı"});
        }

        private static void ColorGetAll(ColorManager colorManager)
        {
            var result = colorManager.GetAll();
            if (result.Success)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.Name);
                }
            }
            Console.WriteLine(result.Message);
            
        }

        private static void BrandAdd(BrandManager brandManager)
        {
            brandManager.Add(new Brand {Name = "Dacia Duster"});
        }

        private static void BrandGetAll(BrandManager brandManager)
        {
            var result = brandManager.GetAll();
            if (result.Success)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.Id + " " + item.Name);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void UserAdd(UserManager userManager)
        {
            userManager.Add(new User
            {
                FirstName = "Banu",
                LastName = "Alaz",
                Email = "banualaz@gmail.com",
                Password = "987654321"
            });
        }

        private static void UserGetAll(UserManager userManager)
        {
            var result = userManager.GetAll();

            if (result.Success)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.Id + " " + item.FirstName + " " + item.LastName + " " + item.Email + " " +
                                      item.Password);
                    Console.WriteLine(result.Message);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
