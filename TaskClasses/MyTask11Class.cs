using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class MyTask11Class
    {
        public MyTask11Class(double y,double x)
        {
            _y = y;
            _x = x;

        }

        public double _y { get; set; }
        public double _x { get; set; }

        public double I()
        {
            return 2.33 * Math.Log(Math.Sqrt(1 + Math.Pow(Math.Cos(_y), 2))) / (Math.Exp(_y) + Math.Pow(Math.Sin(_x), 2));
        }
    }
}
