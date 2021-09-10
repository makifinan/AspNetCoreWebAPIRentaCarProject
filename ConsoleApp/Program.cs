using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //UserManager userManager = new UserManager(new EfUserDal());

            //CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            //customerManager.Add(new Customer { UserId = 1, CompanyName = "İnnMedya" });


            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { Id = 1, BrandId = 1, CarName = "Audi", ColorId = 1, DailyPrice = 500, Description = "Audi", ModelYear = 2016 });

        }
    }
}
