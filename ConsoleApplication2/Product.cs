using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Product
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        [MaxLength(1)]
        public int Rate { get; set; }
        public double Price { get; set; }
    }
}
