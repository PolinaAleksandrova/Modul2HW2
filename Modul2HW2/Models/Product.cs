using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW2.Models
{
    public class Product
    {
        public double Price { get; set; }
        public bool IsExist { get; set; }
        public string Name { get; set; }
        public Guid Guid { get; set; }
        public Currency Currency { get; set; }
    }
}
