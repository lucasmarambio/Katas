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
            var result = new List<string>();
            
            for (int i = 1; i <= count; i++)
            {
                var number = new Number(i);
                result.Add(number.ToString());
            }

            return result;
        }
    }
}