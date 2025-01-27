using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class MyTask3Class
    {
        
        public MyTask3Class(double y, double k)
        {
            _y = y;
            _h = k;
        }

        public double _y { get; set; }
        public double _h { get; set; }

        public double A()
        {
            return (Math.Tan(Math.Pow(_y, 3) - Math.Pow(_h, 4)) + Math.Pow(_h, 2)) / (Math.Pow(Math.Sin(_h), 3) + _y);
        }
    }
}

