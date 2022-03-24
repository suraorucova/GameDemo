using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    internal class SalesManager : ISalesService
    {
        public void Sales(IGameSalesService gameSalesService, ICanpaignsService canpaignsService, Customer customer)
        {
            gameSalesService.Sales(customer, canpaignsService);
        }
    }
}
