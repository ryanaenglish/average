using System;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            //Output Average
            double Test_A = 0.0;
            double Test_B = 0.0;
            double Test_C = 0.0;
            double Average = 0.0;

            
            //Input
            Console.Write(" Enter Test Score A ");
            Test_A = double.Parse(Console.ReadLine());
            Console.Write(" Enter Test Score B ");
            Test_B = double.Parse(Console.ReadLine());
            Console.Write(" Enter Test Score C ");
            Test_C = double.Parse(Console.ReadLine());

            Average = (Test_A + Test_B + Test_C) / 3.0;

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Your Average is " + Average);

            Console.ReadKey();
        }
    }
}
