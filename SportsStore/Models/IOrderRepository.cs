using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace SportsStore.Models
{
    public interface IOrderRepository
    {
        IQueryable<Order> Orders { get; }
        void SaveOrder(Order order);
    }
}
