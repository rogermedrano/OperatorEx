using System;

namespace OperatorEx
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 19;
            int b = 5;
            int quotient = a / b;
            int remainder = a % b;
            Console.WriteLine($"{a} divided by {b} is {quotient} with a remainder of {remainder}");

            Console.WriteLine("-------------------------------------------------------------");
            if (a == 19 && b == 5)
                Console.WriteLine($"{a} / {b} is {quotient} with a remainder of {remainder}.");
            Console.WriteLine("-------------------------------------------------------------");

            Console.WriteLine("BTW, this is better than Common Core math...just sayin.");

            Console.WriteLine("-------------------------------------------------------------");

            int i = 3;
            int j = 4;
            int k = ++i * j++;
            Console.WriteLine(k);
        }

    }
}
