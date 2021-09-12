using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW2.Models;

namespace Modul2HW2.Services
{
    public class OrderService
    {
        public OrderService()
        {
            Order = new Order();
        }

        public Order Order { get; set; }
        public void OrderComplete()
        {
            Order.Guid = Guid.NewGuid();
        }
    }
}
