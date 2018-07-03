using System;

namespace FizzBuzzLib
{
    public class FizzBuzz
    {
        public string GetResult(int number)
        {
            string result = string.Empty;
            if (number > 1000)
            {
                throw new Exception("Number exceeds 1000.");
            }
            for (int i = 1; i <= number; i++)
            {
                if (i % 15 == 0)
                {
                    result += "fizzbuzz ";
                }
                else if (i % 3 == 0)
                {
                    result += "fizz ";
                }
                else if (i % 5 == 0)
                {
                    result += "buzz ";
                }
                else
                {
                    result += i.ToString() + " ";
                }
            }
            return result;
        }
    }
}
