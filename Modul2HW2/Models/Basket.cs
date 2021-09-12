using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW2.Services;
namespace Modul2HW2.Models
{
    public class Basket
    {
        private static readonly Basket _basketValue = new Basket();
        private readonly Product[] _products;
        private readonly ConfigService _configService;
        static Basket()
        {
        }

        private Basket()
        {
            _configService = new ConfigService();
            _products = new Product[_configService.BasketConfig.BasketLength];
        }

        public Product[] Products => _products;
        public static Basket BasketValue => _basketValue;
    }
}
