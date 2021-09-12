using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW2.Services;
using Modul2HW2.Models;
using Modul2HW2.Providers;

namespace Modul2HW2
{
    public class Starter
    {
        private readonly BasketService _basketService;
        private readonly NotificationService _notificationService;
        private readonly OrderService _orderService;
        private readonly ProductProvider _productProvider;
        private readonly User _user;

        public Starter()
        {
            _basketService = new BasketService();
            _notificationService = new NotificationService();
            _orderService = new OrderService();
            _productProvider = new ProductProvider();
            _user = new User() { PhoneNumber = "+380608945345", Email = "user@gmail.com", Name = "Ivan Ivanov" };
        }

        public void Run()
        {
            var random = new Random();
            var randOrder = 0;
            for (var i = 0; i < 10; i++)
            {
                randOrder = random.Next(0, 20);
                _basketService.AddProduct(_productProvider.Products[randOrder]);
            }

            _orderService.OrderComplete();
            _notificationService.Notificate(_orderService.Order.Guid, _user);
        }
    }
}
