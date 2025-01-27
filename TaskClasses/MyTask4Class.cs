using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class MyTask4Class
    {
        
        public MyTask4Class(double y, double x)
        {
            _y = y;
            _x = x;
        }

        public double _y { get; set; }
        public double _x { get; set; }

        public double F()
        {
            return Math.Sqrt(Math.Pow(2 + _y, 2) + Math.Pow(Math.Sin(_y + 5), 1 / 7)) / (Math.Log(_x + 1) - Math.Pow(_y, 3));
        }
    }
}

