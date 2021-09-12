using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW2.Models;
namespace Modul2HW2.Services
{
    public class NotificationService
    {
        public void Notificate(Guid orderId, User user)
        {
            if (user.PhoneNumber != null)
            {
                PhoneNotificate(orderId);
            }

            if (user.Email != null)
            {
                EmailNotificate(orderId);
            }
        }

        private void PhoneNotificate(Guid orderId)
        {
            Console.WriteLine($"Номер заказа по номеру телефона: {orderId}");
        }

        private void EmailNotificate(Guid orderId)
        {
            Console.WriteLine($"Номер заказа по почте: {orderId}");
        }
    }
}
