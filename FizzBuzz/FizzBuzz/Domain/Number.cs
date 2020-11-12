using FizzBuzz.Domain;

namespace FizzBuzz
{
    // This is a value object
    public class Number : Numbers
    {
        private int _number;

        private Number(int num)
        {
            _number = num;
        }

        public static Number Create(int num) => new Number(num);

        public override string ToString() => _number.ToString();
    }
}
