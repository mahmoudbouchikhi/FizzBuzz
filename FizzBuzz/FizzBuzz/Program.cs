using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine(FizzBuzz(i));
            }
            Console.ReadKey();
        }
        public static string FizzBuzz(int number)
        {
            //if divisible by 3 == Fizz
            //if divisible by 5 == Buzz
            //if divisible by both == FizzBuzz
            
            if (number % 3 == 0 && number % 5 == 0)
            {
                //FizzBuzz
                return "FizzBuzz";
            }
            else if (number % 3 == 0)
            {
                // Fizz
                return "fizz";
            }
            else if (number % 5 == 0)
            {
                //Buzz
                return "Buzz";
            
            }
            else
            {
                //number
                return number.ToString();
            }

        }
    }
}



