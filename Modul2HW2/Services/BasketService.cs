using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW2.Models;

namespace Modul2HW2.Services
{
    public class BasketService
    {
        public Basket Basket
        {
            get
            {
                return Basket.BasketValue;
            }
        }

        public void AddProduct(Product product)
        {
            for (int i = 0; i < Basket.Products.Length; i++)
            {
                if (Basket.Products[i] == null)
                {
                    Basket.Products[i] = product;
                    break;
                }
            }
        }
    }
}
