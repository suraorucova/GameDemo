using GameDemo.Abstract;
using GameDemo.Concrete;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo
{
    internal class Program
    {
        static void Main(string[] args,DateTime p)
        {
            Customer customer = new Customer();
            customer.FirstName = "Sura";
            customer.LastName = "Mammadova";
            (int, int, int) p = (1999, 11, 2);
            customer.DateOfBirgth = p;


            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer);
            customerManager.Delete(customer);
            customerManager.Update(customer);

            IGameSalesService buyMoney = new BuyMoney();


            ICanpaignsService BaharCanpanign = new BaharCanpaign();

            SalesManager salesManager = new SalesManager();
            salesManager.Sales(buyMoney, new BaharCanpaign, customer);


            Console.ReadLine();
        }
    }
}
