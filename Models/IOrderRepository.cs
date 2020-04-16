using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using burguerwebapp.Models;


namespace burguerwebapp.Controllers
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}