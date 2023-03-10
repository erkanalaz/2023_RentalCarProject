using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Protocols;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal:EfEntityRepositoryBase<Car,RentalCarContext>,ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentalCarContext context = new RentalCarContext())
            {
                var result = from c in context.Cars
                    join b in context.Brands
                        on c.BrandId equals b.Id
                    join clr in context.Colors
                        on c.ColorId equals clr.Id
                    select new CarDetailDto
                    {
                        CarName = c.Description,
                        BrandName = b.Name,
                        ColorName = clr.Name,
                        DailyPrice = c.DailyPrice
                    };
                return result.ToList();
            }
        }

        public List<CarDetailDto> GetCarDetailsByBrandId(int id)
        {
            using (RentalCarContext context = new RentalCarContext())
            {
                var result = from c in context.Cars
                    join b in context.Brands
                        on c.BrandId equals b.Id
                    join clr in context.Colors
                        on c.ColorId equals clr.Id
                             where c.BrandId==id
                    select new CarDetailDto
                    {
                        CarName = c.Description,
                        BrandName = b.Name,
                        ColorName = clr.Name,
                        DailyPrice = c.DailyPrice
                    };
                return result.ToList();
            }
        }



        public List<CarDetailDto> GetCarDetailsByColorId(int id)
        {
            using (RentalCarContext context = new RentalCarContext())
            {
                var result = from c in context.Cars
                    join b in context.Brands
                        on c.BrandId equals b.Id
                    join clr in context.Colors
                        on c.ColorId equals clr.Id
                    where clr.Id == id
                    select new CarDetailDto
                    {
                        CarName = c.Description,
                        BrandName = b.Name,
                        ColorName = clr.Name,
                        DailyPrice = c.DailyPrice
                    };
                return result.ToList();
            }
        }



    }
}
