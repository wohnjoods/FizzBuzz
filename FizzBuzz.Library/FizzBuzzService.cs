using System;
using System.Collections.Generic;

namespace FizzBuzz.Library
{
    public class FizzBuzzService
    {
        public string Print(int v)
        {
            if(IsDivisibleBy3(v) && IsDivisibleBy5(v))
                return "FizzBuzz";
            else if(IsDivisibleBy5(v))
                return "Buzz";
            else if(IsDivisibleBy3(v))
                return "Fizz";
            else
               return v.ToString();
        }
        private bool IsDivisibleBy3(int number)
        {
            return number % 3 == 0;
        }
        private bool IsDivisibleBy5(int number)
        {
            return number % 5 == 0;
        }
    }
}