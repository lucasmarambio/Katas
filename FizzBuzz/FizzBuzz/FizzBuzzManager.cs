using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    public class FizzBuzzManager
    {
        public FizzBuzzManager()
        {
        }

        public List<string> CountUpTo(int count)
        {
            ThrowExceptionIfOutOfRange(count);

            var result = new List<string>();
            
            for (int i = 1; i <= count; i++)
            {
                var number = new Number(i);
                result.Add(number.ToString());
            }

            return result;
        }

        private void ThrowExceptionIfOutOfRange(int number)
        {
            if (number < 1)
            {
                throw new ArgumentOutOfRangeException("number", number, "Number must be greater than 0");
            }
            else if (number > 100)
            {
                throw new ArgumentOutOfRangeException("number", number, "Number must be less than 101");
            }
        }
    }
}