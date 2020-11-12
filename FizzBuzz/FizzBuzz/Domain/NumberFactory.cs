using System;
using FizzBuzz.Domain;

namespace FizzBuzz
{
    public class NumberFactory
    {
        public static Numbers Create(int num) 
        {
            if (ValidateNumRange(num))
            {
                return CreateNumber(num);
            }

            return null;
        }

        private static Numbers CreateNumber(int num)
        {
            if (IsFizz(num))
            {
                return new Fizz();
            }
            else if (IsBuzz(num))
            {
                return new Buzz();
            }
            else
            {
                return Number.Create(num);
            }
        }

        private static bool ValidateNumRange(int num)
        {
            if (num < 1)
            {
                throw new ArgumentOutOfRangeException("number", num, "Number must be greater than 0");
            }
            else if (num > 100)
            {
                throw new ArgumentOutOfRangeException("number", num, "Number must be less than 101");
            }

            return true;
        }

        private static bool IsFizz(int num)
        {
            return (num % 3) == 0;
        }

        private static bool IsBuzz(int num)
        {
            return (num % 5) == 0;
        }
    }
}