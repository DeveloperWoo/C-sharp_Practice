using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte number = 2;
            //int count = 10;
            //float totalPrice = 20.95f;
            //char character = 'A';
            //string firstName = "Hyunju";
            //bool isWorking = false;

            var number = 2; //By default, 2 is considered as an integer
            var count = 10;
            var totalPrice = 20.95f; //By default, a real number is treated as double
            var character = 'A';
            var firstName = "Hyunju";
            var isWorking = false;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
          
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue); // 0 255
        }
    }
}
