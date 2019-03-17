using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Language_Basics
{
    class Program
    {

        static int Sum(params int[] ints)                       //Keyword params on the last parametr in method can allow to load any number of arguments during its call.
        {
            int sum = 0;
            for (int i = 0; i < ints.Length; i++)
            {
                sum = sum + ints[i];
            }
            return sum;
        }

        static void Split(string name, out string firstNames, out string lastNames)         //Splitting strings by spaces
        {
            int i = name.LastIndexOf(' ');                                                  //Getting index of last char symbol usage
            firstNames = name.Substring(0, i);                                              //Cutting a string from point a to point b
            lastNames = name.Substring(i + 1);
        }

        static void StringSwap(string a, string b)      //Method for swapping values in reference type variables
        {
            string temp = a;                                    //Variable for temporary storage of value 
            a = b;
            b = temp;
        }
        static void Foo2(ref int a)
        {
            a = a + 1;
            Console.WriteLine(a);
        }
        static void Foo(int p)
        {
            p = p + 1;             // Increments p by 1
            Console.WriteLine(p);  //Write p to screen
        }

        static void Main(string[] args)
        {
            //int x = 8;
            //Foo(x);                 //By default variables are passed to methods by value
            //Console.WriteLine(x);   //X will still be 8 because two methods have interact with X within different memory locations.

            //int x = 8;
            //Foo2(ref x);                //Using keyword ref you can pass variable not by value but by reference. You need to build method accordingly.
            //Console.WriteLine(x);

            //string name = "Dusmikeev";
            //string surname = "Denis";

            //Console.WriteLine(name);
            //Console.WriteLine(surname);

            //Split("Dusmikeev Denis", out string b, out string a);
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            Console.WriteLine(Sum(1, 2, 3, 4, 5));
            

            Console.Read();
        }
    }
}
