using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp10
{
    public class Market
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Amout { get; set; }


        public override string ToString()
        {
            return $"{ProductName}";
        }
    }
}
