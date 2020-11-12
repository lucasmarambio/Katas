using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    public class FizzBuzzManager
    {
        public List<string> CountUpTo(int count)
        {
            return CountFizzBuzz(count);
        }

        // This approach avoids the temp variables and is more readable.
        // Temp variables are dangerous since it allows other developers to change the behavior of the method.
        private static List<string> CountFizzBuzz(int count) => 
            Enumerable.Range(1, count).Select(x => NumberFactory.Create(x).ToString()).ToList();
    }
}