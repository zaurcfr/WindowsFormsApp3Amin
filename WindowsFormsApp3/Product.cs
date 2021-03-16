using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Product
    {
        public string ProductName { get; set; }
        public string Country { get; set; }
        public string Cost { get; set; }
        public override string ToString()
        {
            return $"{ProductName}\t{Country}\t{Cost}";
        }
    }
}
