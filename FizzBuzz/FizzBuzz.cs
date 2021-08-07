using System;

namespace C_
{
    class FizBuzz
    {
        static void Main(string[] args)
        {
            string numbersLength = Console.ReadLine();
            for (int i = 1; i < (String.IsNullOrEmpty(numbersLength)? 100 : int.Parse(numbersLength)); i++)
            {
                string result = "";
                if (i % 3 == 0)
                {
                    result += "Fizz";
                }
                if (i % 5 == 0)
                {
                    result += "Buzz";
                }

                if (result != "") 
                {
                    Console.WriteLine(result);
                }
                else {
                    Console.WriteLine(i);              
                }
            }
        }
    }
}
