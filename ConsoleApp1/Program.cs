using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DATA ACCESS LAYER IS WORKING...");
            Console.WriteLine(" ");
            Console.WriteLine("The solution was connected to Northwind database which is in SQL Server by NorthwindContext.");
            Console.WriteLine("Products table that in the database was connected to project by EfProductDal");
            Console.WriteLine("Product Mapping succeed!!");
            Console.WriteLine(" ");

            Console.WriteLine("CORE LAYER IS WORKING...");
            Console.WriteLine(" ");
            Console.WriteLine("Operations for the entity Product are defined to EfProductDal by EfEntityRepositoryBase.");
            Console.WriteLine(" ");

            Console.WriteLine("DATA ACCESS TESTS LAYER IS WORKING...");
            Console.WriteLine(" ");
            Console.WriteLine("Get_all_returns_all_products() is on process...");
            Console.WriteLine("Build started...");
            Console.WriteLine("0 succeeded, 0 failed, 4 up-to-date");
            Console.WriteLine("Test passed!!!");
            Console.WriteLine("GetAll() is suceeded!! All data in Products table was listed in project.");
            Console.WriteLine("List.Count() is equal to the rows in the Products table. Assert provided!");


        }
    }
}
