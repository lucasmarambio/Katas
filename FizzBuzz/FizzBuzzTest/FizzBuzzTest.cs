using FizzBuzz;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzBuzzTest
    {
        private FizzBuzzManager _fizzBuzzManager;

        public FizzBuzzTest()
        {
            _fizzBuzzManager = new FizzBuzzManager();
        }

        [Fact]
        public void ShouldValidate_1()
        {
            EvaluateFizzBuzz(1, new List<string>() { "1" });
        }

        [Fact]
        public void ShouldValidate_2()
        {
            EvaluateFizzBuzz(2, new List<string>() { "1", "2" });
        }

        [Fact]
        public void ShouldValidate_3()
        {
            EvaluateFizzBuzz(3, new List<string>() { "1", "2", Constants.Fizz});
        }

        [Fact]
        public void ShouldValidate_4()
        {
            EvaluateFizzBuzz(4, new List<string>() { "1", "2", Constants.Fizz, "4" });
        }

        [Fact]
        public void ShouldValidate_5()
        {
            EvaluateFizzBuzz(5, new List<string>() { "1", "2", Constants.Fizz, "4", Constants.Buzz });
        }

        [Fact]
        public void ShouldValidate_6()
        {
            EvaluateFizzBuzz(6, new List<string>() { "1", "2", Constants.Fizz, "4", Constants.Buzz, Constants.Fizz });
        }

        [Fact]
        public void ShouldValidate_ExceptionLessThan1()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => EvaluateFizzBuzz(0, new List<string>()));
        }

        private void EvaluateFizzBuzz(int count, List<string> expected)
        {
            var result = _fizzBuzzManager.CountUpTo(count);
            Assert.True(result.SequenceEqual(expected));
        }
    }
}
