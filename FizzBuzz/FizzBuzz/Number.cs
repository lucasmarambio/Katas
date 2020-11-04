namespace FizzBuzz
{
    public class Number
    {
        private int _number;

        public Number(int num)
        {
            _number = num;
        }

        public override string ToString() {
            return IsFizz() ? Constants.Fizz : IsBuzz()? Constants.Buzz : _number.ToString();
        }

        private bool IsFizz()
        {
            return (_number % 3) == 0;
        }

        private bool IsBuzz()
        {
            return (_number % 5) == 0;
        }
    }
}
