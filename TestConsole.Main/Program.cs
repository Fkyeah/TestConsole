using System;

namespace TestConsole.Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 1;

            var math = new MathMethods();

            var result = math.Plus(a, b);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
