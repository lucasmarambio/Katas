using System;
using System.Collections.Generic;
using System.Linq;
using FizzBuzz;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzBuzzTest
    {
        private readonly FizzBuzzManager _fizzBuzzManager;

        public FizzBuzzTest()
        {
            _fizzBuzzManager = new FizzBuzzManager();
        }

        public static IEnumerable<object[]> Data =>
            new List<object[]>
            {
                new object[] { 1, new List<string>() { "1" } },
                new object[] { 2, new List<string>() { "1", "2" } },
                new object[] { 3, new List<string>() { "1", "2", Constants.Fizz } },
                new object[] { 4, new List<string>() { "1", "2", Constants.Fizz, "4" } },
                new object[] { 5, new List<string>() { "1", "2", Constants.Fizz, "4", Constants.Buzz } },
                new object[] { 6, new List<string>() { "1", "2", Constants.Fizz, "4", Constants.Buzz, Constants.Fizz } },
            };

        [Theory]
        [MemberData(nameof(Data))]
        public void ShouldValidateBasic(int count, List<string> expected)
        {
            var sut = _fizzBuzzManager.CountUpTo(count);
            Assert.True(sut.SequenceEqual(expected));
        }

        [Fact]
        public void ShouldValidate_ExceptionLessThan1()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _fizzBuzzManager.CountUpTo(101));
        }
    }
}
