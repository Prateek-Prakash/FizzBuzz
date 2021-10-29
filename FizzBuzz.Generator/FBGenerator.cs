using System;

namespace FizzBuzz.Generator
{
    public class FBGenerator
    {
        public string Generate(int inputNum)
        {
            if (inputNum % 3 == 0 && inputNum % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (inputNum % 3 == 0)
            {
                return "Fizz";
            }
            else if (inputNum % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return inputNum.ToString();
            }
        }
    }
}
