using System;
using Xunit;
using FizzBuzzLib;

namespace FizzBuzzTest
{
    public class FizzBuzzTest
    {
        [Fact]
        public void Given2Return12()
        {
            FizzBuzz fb = new FizzBuzz();
            string expected = "1 2 ";
            string actual = fb.GetResult(2);
            Assert.Equal(expected, actual);


        }

        [Fact]
        public void Given3Return12fizz()
        {
            FizzBuzz fb = new FizzBuzz();
            string expected = "1 2 fizz ";
            string actual = fb.GetResult(3);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Given5Return12fizz4buzz()
        {
            FizzBuzz fb = new FizzBuzz();
            string expected = "1 2 fizz 4 buzz ";
            string actual = fb.GetResult(5);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Given15Return12fizz4buzz_ect()
        {
            FizzBuzz fb = new FizzBuzz();
            string expected = "1 2 fizz 4 buzz fizz 7 8 fizz buzz 11 fizz 13 14 fizzbuzz ";
            string actual = fb.GetResult(15);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GreaterThan1000ThrowException()
        {
            FizzBuzz fb = new FizzBuzz();
            Action act = () => fb.GetResult(1001);

            Assert.Throws<Exception>(act);


        }
    }
}
