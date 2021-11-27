using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{

    public class Program
    {
        static void Main(string[] args)
        {
            FizzBuzzer fb = new FizzBuzzer();
            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine(fb.FizzBuzz4(i));
            }
            Console.ReadKey();
        }



    }

    public class FizzBuzzer
    {

        //start simple by "faking it". Here weve just written enough code to make the test turn green
        public string FizzBuzz(int input)
        {
            return "1";
        }

        //we know that 3 will be the first number to produce fizz and 5 will be the first buzz. so we start off easy by manually defining them with iff statements.
        public string FizzBuzz2(int input)
        {
            if (input == 3)
            {
                return "Fizz";
            }
            if (input == 5)
            {
                return "Buzz";
            }
            return input.ToString();
        }

        //we expand on our functionality by including all factors of 3 & 5 (with no remainders)
        public string FizzBuzz3(int input)
        {
            if (input % 3 == 0)
            {
                return "Fizz";
            }
            if (input % 5 == 0)
            {
                return "Buzz";
            }
            return input.ToString();
        }

        //eventually by gradually increasing the complexity of our code, we ensure that our code can meet all the expected requirements whilst hopefully ensuring that code has remained as efficent as possible.
        //The below code will return Fizz for all factors of 3, buzz for all factrors of 5 and fizzbuzz for all factors of both.
        public string FizzBuzz4(int input)
        {
            string result = string.Empty;
            if (input % 3 == 0)
            {
                result = "Fizz";
            }
            if (input % 5 == 0)
            {
                result += "Buzz";
            }
            if (result == string.Empty)
            {
                result = input.ToString();
            }
            return result;
        }

    }

  

}




