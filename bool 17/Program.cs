using System;

namespace bool_16
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var result = (a >= 100 && a <= 999);
            bool result1 = (a % 2 != 0);
            
            
            Console.WriteLine(result1);

        }
    }
}