using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineLength
{
    public class CompareTo_uc3
    {
        public void CompareToMethod(double finalResult, double finalResult2)
        {
            int res = finalResult.CompareTo(finalResult2);
            Console.WriteLine(res);
            if (res == 0)
            {
                Console.WriteLine("Lengths are equal!");
            }
            if (res >= 0)
            {
                Console.WriteLine("Line 1 is greator than line 2 ");
            }
            else
            {
                Console.WriteLine("Line 2 is greator than line 1 ");
            }
        }
    }
}
