using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversions
{
    class Program
    {
        static int Max(int a, int b)
        {
            return (a > b) ? a : b;
        }

        public struct Dude
        {
            public string Name;
            public Dude(string n)
            {
                Name = n;
            }
        }

        static void Main(string[] args)
        {
            //int x = 12345;
            //long y = x;
            //short z = (short)x;

            //int a = 0; int b = 0;
            //Console.WriteLine(a++);
            //Console.WriteLine(++b);

            //int minimumInt = int.MinValue;
            //minimumInt--;
            //Console.WriteLine(minimumInt == int.MaxValue);

            //Console.WriteLine(-1.0 / 0.0);

            //Dude dude1 = new Dude("John");
            //Dude dude2 = dude1;
            //dude1.Name = "Karl";

            //Console.WriteLine(dude1.Name);
            //Console.WriteLine(dude2.Name);

            //int maxNumber = Max(10,15);
            //Console.WriteLine(maxNumber);

            int x = 4;
            Console.WriteLine($"A square has {x} sides");

            Console.Read();
        }
    }
}
