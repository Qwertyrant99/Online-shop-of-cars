using SklepInternetowy.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SklepInternetowy.Data.Intefaces
{
    public interface IAllOrders
    {
        void createOrder(Order order);
    }
}
