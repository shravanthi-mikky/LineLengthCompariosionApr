using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineLength
{
    public class UC1
    {
            public double Distance(double x1, double x2, double y1, double y2)
            {
                var temp1 = Math.Pow((x2 - x1), 2);
                var temp2 = Math.Pow((y2 - y1), 2);
                var result = Math.Sqrt(temp1 + temp2);
                return result;
            }
            public double Input()
            {
                Console.WriteLine("Please Enter the value of the coordinate");
                double a = Convert.ToDouble(Console.ReadLine());
                return a;
            }
    }
}
