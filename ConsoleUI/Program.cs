using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            productManager.Add(new Product {BrandName="Lenovo",CategoryId=1,Model="Xc60",Properties="Yüksek Performans" });
            foreach (var x in productManager.GetAll())
            {
                Console.WriteLine(x.BrandName);
            }
        
        }
    }
}
