using System;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            god god = new god();
            god.poxyi(new[] { 20, 1, -1, 2, -2, 3, 3, 5, 1, 1, 2, 4, 20, 4, -1, -2, 5 });
            Console.ReadLine();
        }
    }
}
