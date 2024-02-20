using System;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            god god = new god();
            god.CreatePhoneNumber(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 });
            Console.ReadLine();

        }
    }
}
