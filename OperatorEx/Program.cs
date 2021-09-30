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
            //Solution is '16'


            AreaOfCircle();
        }

        //EXERCISE 2:  AREA OF A CIRCLE

       
        static void AreaOfCircle()
        {
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Now lets calculate the area of a circle.");
            Console.WriteLine("");

            Console.WriteLine(""); double pi = 3.14;
            Console.WriteLine("Enter the radius of your circle. The area will be based on your unit of measure: ");
            double radius = double.Parse(Console.ReadLine());
            double areaCircle = pi * radius * radius;
            Console.WriteLine($"Based on your radius of {radius}, the area of your circle is {areaCircle}.");
        }
    }
}
