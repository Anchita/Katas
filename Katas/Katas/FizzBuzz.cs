/*Write a function that takes numbers from 1 to 100 and outputs them as a string, but for
multiples of three it returns “Fizz” instead of the number, and for multiples of five it returns
“Buzz.” For numbers that are multiples of both three and five, it returns “FizzBuzz.”*/

using NUnit.Framework;

namespace Katas
{
    public class FizzBuzzTests
    {
        [TestCase(1, "1")]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        public void GivenAnOdNumberThenReturnFizz(int num, string expected)
        {
            FizzBuzz fb = new FizzBuzz();
            string result = fb.Process(num);
            Assert.AreEqual(expected, result);
        }
    }
    class FizzBuzz
    {
        public string Process(int num)
        {
            if (IsDivisibleBy3(num) && IsDivisibleBy5(num))
            {
                return "FizzBuzz";
            }
            else
            {
                if (IsDivisibleBy3(num))
                {
                    return "Fizz";
                }
                else if (IsDivisibleBy5(num))
                {
                    return "Buzz";
                }
            }
            return num.ToString();

        }

        public bool IsDivisibleBy3(int num)
        {
            if (num % 3 == 0)
            {
                return true;
            }
            return false;
        }

        public bool IsDivisibleBy5(int num)
        {
            if (num % 5 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
