using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class MyTask14Class
    {
        public MyTask14Class(double x)
        {
            _x = x;
        }

        public double _x { get; set; }

        public double R()
        {
            return Math.Sin(Math.Pow(Math.Pow(_x, 2) + 4, 3) + 4.3) / Math.Pow(Math.Sin(Math.Pow(_x, 4)), 3);
        }
    }
}
