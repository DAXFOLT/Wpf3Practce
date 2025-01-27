using System;

namespace WpfApp6
{
    public class MyTask12Class
    {
        public MyTask12Class(double y, double a, double x)
        {
            _y = y;
            _x = x;
            _a = a;
        }

        public double _y { get; set; }
        public double _x { get; set; }
        public double _a { get; set; }

        public double G()
        {
            return (Math.Pow(Math.Cos(Math.Abs(_y + _x)), 3) - (_x + _y)) / Math.Pow(Math.Atan(_x + _a), 4) * Math.Pow(_x, 5);
        }
    }
}
