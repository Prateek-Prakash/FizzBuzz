using FizzBuzz.Generator;
using System;
using Xunit;

namespace FizzBuzz.Tests
{
    public class FBGeneratorTest
    {
        [Fact]
        public void FizzTest()
        {
            FBGenerator fBGenerator = new FBGenerator();
            string returnString = fBGenerator.Generate(3);
            Assert.Equal("Fizz", returnString);
        }

        [Fact]
        public void BuzzTest()
        {
            FBGenerator fBGenerator = new FBGenerator();
            string returnString = fBGenerator.Generate(5);
            Assert.Equal("Buzz", returnString);
        }

        [Fact]
        public void FizzBuzzTest()
        {
            FBGenerator fBGenerator = new FBGenerator();
            string returnString = fBGenerator.Generate(15);
            Assert.Equal("FizzBuzz", returnString);
        }

        [Fact]
        public void NumberTest()
        {
            FBGenerator fBGenerator = new FBGenerator();
            string returnString = fBGenerator.Generate(1);
            Assert.Equal("1", returnString);
        }
    }
}
