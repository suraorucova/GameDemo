using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    internal class CustomerManager : ICustomerService
    { ICheckIfRealSevice _checkIfRealSevice;
        private ICheckIfRealSevice _checkIfRealService;

        public CustomerManager()
        {
        }

        public CustomerManager(ICheckIfRealSevice checkIfRealSevice)
        {
            _checkIfRealService = checkIfRealSevice;
        }
        public void Add(Customer customer)
        {
            if (_checkIfRealService.CheckIfReal(customer))
            {
                Console.WriteLine("Yeni oyuncu eklendi" + customer.FirstName);
            }
            else
            {
                throw new Exception("Oyuncu bulunamadi");
            }
        }

        public void Delete(Customer customer)
        {
           if (_checkIfRealService.CheckIfReal(customer))
            {
                Console.WriteLine("Oyuncu silindi"+customer.FirstName);
            }
            else
            {
                throw new Exception("Oyuncu bulunamadi");
            }
        }

        public void Update(Customer customer)
        {
            if (_checkIfRealService.CheckIfReal(customer))
            {
                Console.WriteLine("Oyuncu guncellendi" + customer.FirstName); 
            }
            else
            {
                throw new Exception("Oyuncu bulunamadi");
            }
        }
    }
}
