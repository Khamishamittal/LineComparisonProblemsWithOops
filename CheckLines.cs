using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonWithOops
{
    public class CheckLines
    {
        public Double x1, x2, y1, y2, Line1;
        public Double x3, x4, y3, y4, Line2;
        public void CalculateLength()
        {
            Console.WriteLine("Enter First Line Coordinates");
            Console.WriteLine("Enter x1:");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y1:");
            y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter x2:");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y2:");
            y2 = Convert.ToDouble(Console.ReadLine());

            Line1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Line1 Length is {0}", Line1);
            Console.WriteLine();




            Console.WriteLine("Enter Second Line Coordinates");
            Console.WriteLine("Enter x3:");
            x3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y3:");
            y3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter x4:");
            x4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y4:");
            y4 = Convert.ToDouble(Console.ReadLine());

            Line2 = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));
            Console.WriteLine("Line2 Length is {0}", Line2);
            Console.WriteLine();

        }

        public void checkEqual()
        {
            if (Line1 == Line2)
            {
                Console.WriteLine("Length of Both Lines are Equal");
            }
            else
            {
                Console.WriteLine("Length of Both Lines are Not Equal");
            }
            Console.WriteLine();

        }

        public void compare()
        {
            if (Line1 > Line2)
            {
                Console.WriteLine("Line1 is greater than Line2");
            }
            else if (Line1 < Line2)
            {
                Console.WriteLine("Line2 is greater than Line1");
            }
            else
            {
                Console.WriteLine("Line1 is equal to Line2");
            }
        }
    }
}
