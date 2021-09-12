using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW2.Models;

namespace Modul2HW2.Providers
{
    public class ProductProvider
    {
        private Product[] _products = new Product[20];

        public ProductProvider()
        {
            Products[0] = new Product() { Name = "Camera GoPro HERO7 Black", Price = 8000, Currency = Currency.UAH, IsExist = true };
            Products[1] = new Product() { Name = "Camera Olympus PEN E-PL10 Black", Price = 16000, Currency = Currency.UAH, IsExist = true };
            Products[2] = new Product() { Name = "Logitech H390 Wired Headset", Price = 4000, Currency = Currency.UAH, IsExist = true };
            Products[3] = new Product() { Name = "Logitech BRIO Ultra HD Webcam", Price = 7000, Currency = Currency.UAH, IsExist = true };
            Products[4] = new Product() { Name = "Logitech C920x HD Pro Webcam", Price = 2000, Currency = Currency.UAH, IsExist = true };
            Products[5] = new Product() { Name = "SanDisk 128GB Ultra MicroSDXC", Price = 400, Currency = Currency.UAH, IsExist = true };
            Products[6] = new Product() { Name = "Blue Yeti USB Microphone", Price = 2000, Currency = Currency.UAH, IsExist = true };
            Products[7] = new Product() { Name = "BENGOO G9000 Stereo Gaming Headset", Price = 3000, Currency = Currency.UAH, IsExist = true };
            Products[8] = new Product() { Name = "Kantek LCD Protect Deluxe Privacy Filter", Price = 2000, Currency = Currency.UAH, IsExist = true };
            Products[9] = new Product() { Name = "Logitech M525 Wireless Mouse", Price = 1500, Currency = Currency.UAH, IsExist = true };
            Products[10] = new Product() { Name = "Logitech K350 Wireless Wave Ergonomic Keyboard", Price = 100, Currency = Currency.USD, IsExist = true };
            Products[11] = new Product() { Name = "Elgato Stream Deck XL", Price = 244, Currency = Currency.USD, IsExist = true };
            Products[12] = new Product() { Name = "Logitech MX Anywhere 3 Compact Performance Mouse", Price = 80, Currency = Currency.USD, IsExist = true };
            Products[13] = new Product() { Name = "Amazon Basics Wireless Computer Mouse", Price = 12, Currency = Currency.USD, IsExist = true };
            Products[14] = new Product() { Name = "3M Precise Mouse Pad", Price = 8, Currency = Currency.USD, IsExist = true };
            Products[15] = new Product() { Name = "Logitech MX Master 2S Wireless Mouse", Price = 72, Currency = Currency.USD, IsExist = true };
            Products[16] = new Product() { Name = "Stylus Pen for iPad", Price = 20, Currency = Currency.USD, IsExist = true };
            Products[17] = new Product() { Name = "Wacom DTK1660K0A Cintiq 16 Drawing Tablet", Price = 650, Currency = Currency.USD, IsExist = true };
            Products[18] = new Product() { Name = "Beantech Umido Esoul TheaterMax Controller", Price = 20, Currency = Currency.USD, IsExist = true };
            Products[19] = new Product() { Name = "Stylus Pens for Touch Screens", Price = 10, Currency = Currency.USD, IsExist = true };
        }

        public Product[] Products
        {
            get
            {
                return _products;
            }
        }
    }
}
