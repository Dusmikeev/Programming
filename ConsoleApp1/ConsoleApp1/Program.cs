using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCode
{
    class Program
    {
        public class Point { public int X, Y; };

        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.X = 7;

            Point p2 = p1;
            Console.WriteLine(p1.X);
            Console.WriteLine(p2.X);

            p1.X = 9;
            Console.WriteLine(p1.X);
            Console.WriteLine(p2.X);
            Console.Read();
        }
    }
}
