/************* C# Fundamental tutorial with Mosh Hamedani ************************/
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /********************* Data Type & Variables *************************/
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

            Console.WriteLine(number); //2
            Console.WriteLine(count); //10
            Console.WriteLine(totalPrice); //20.95
            Console.WriteLine(character); //A
            Console.WriteLine(firstName); //Hyunju
            Console.WriteLine(isWorking); //false
          
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue); // 0 255
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue); //-3.402823E+38 3.402823E+38


            /***************************** Convert *****************************/
            int intNum = 1;
            byte byteNum = (byte)intNum;
            Console.WriteLine(byteNum); //1

            int intNum2 = 1000;
            byte byteNum2 = (byte)intNum2;
            Console.WriteLine(byteNum2); //232 : There is data loss

            //string str = "1234";
            var strNum = "1234";
            int intFromStr = Convert.ToInt32(strNum);
            Console.WriteLine(intFromStr); // 1234

            try
            {
                // Unhandled Excepion(The app crashes) => can be solved with 'try-catch block'
                byte byteFromStr = Convert.ToByte(strNum); 
                Console.WriteLine(byteFromStr);
            }
            // If an exception is occurred, this block is excuted and the application does not crash!
            catch (Exception) 
            {
                Console.WriteLine("The number could not be converted to a byte.");
            }

            try
            {
                string strBoolean = "true";
                bool booleanFromString = Convert.ToBoolean(strBoolean);
                Console.WriteLine(booleanFromString); //True
            }
            catch (Exception)
            {
                Console.WriteLine("The string could not be converted to boolean.");
            }


            /***************************** Operators *****************************/
            var a = 10;
            var b = 3;
            var c = 2;

            Console.WriteLine(a/b); //3
            Console.WriteLine((float)a /b); //3.3333..
            Console.WriteLine((float)a/(float)b); //3.3333..

            Console.WriteLine(a < b); //False
            Console.WriteLine(a == b); //False
            Console.WriteLine(a != b); //True

            Console.WriteLine(b < a && c < a); //True
            Console.WriteLine(b < a && c == a); //False
            Console.WriteLine(b < a || c == a); //True  
        }
    }
}
