using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a. add");
            Console.WriteLine("b.sub");
            Console.WriteLine("c. mul");
            Console.WriteLine("d. div");
            Console.WriteLine("e. mod");
            int num1 = 50;
            int num2 = 25;
            Console.WriteLine("select your option 1 to 5");
            int option=Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case1:
            int
            int result;
            result = num1 + num2;
            Console.WriteLine("Value is {0}", result);
            result = num1 - num2;
            Console.WriteLine("Value is {0}", result);
            result = num1 * num2;
            Console.WriteLine("Value is {0}", result);
            result = num1 / num2;
            Console.WriteLine("Value is {0}", result);
            result = num1 % num2;
            Console.WriteLine("Value is {0}", result);
            result = num1++;
            Console.WriteLine("Value is {0}", result);
            result = num1--;
            Console.WriteLine("Value is {0}", result);
            Console.ReadLine();

        }
    }
}
