using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal:ICarDal
    {
        private List<Car> _car;

        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car{Id = 1,BrandId = 1,ColorId = 1,ModelYear = "2022",DailyPrice = 400,Description = "Audi A3"},
                new Car{Id = 2,BrandId = 2,ColorId = 2,ModelYear = "2021",DailyPrice = 350,Description = "BMW 116"},
                new Car{Id = 3,BrandId = 1,ColorId = 3,ModelYear = "2022",DailyPrice = 450,Description = "Opel Astra"},
                new Car{Id = 4,BrandId = 4,ColorId = 4,ModelYear = "2020",DailyPrice = 500,Description = "Hyundai I20"},
                new Car{Id = 5,BrandId = 5,ColorId = 5,ModelYear = "2019",DailyPrice = 250,Description = "Renault Megane"}

            };
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetById(int id)
        {
            return _car.Where(c => c.BrandId == id).ToList();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(c => c.Id == car.Id);
            _car.Remove(carToDelete);

        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
        }
    }
}
