using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class Calculator
    {
        static void Main(string[] args)
        {
            //string numbers = "";
            //string numbers = "1\n2,3,1\n2,3,1\n2,3,1\n2,3,1\n2,3";
            //string numbers = "1\n2,3";
            string numbers = "1\n2,3,-9\n-7,6";
            Console.Write("                  String Calculator \n************************************************\n\n");
            Calculator calculator = new Calculator();
            numbers = calculator.Add(numbers).ToString();
            Console.WriteLine("Total Sum : " + numbers);
            Console.ReadLine();
        }

        public int Add(string numbers)
        {
            int sum = 0;

            if (String.IsNullOrWhiteSpace(numbers))
            {
                return sum;
            }
            else
            {
                if (!String.IsNullOrEmpty(NoOfNegativeNumbers(numbers)))
                {
                    Console.WriteLine("Negatives not allowed.");
                    Console.WriteLine(NoOfNegativeNumbers(numbers) + " are negatives numbers");
                }
                else
                {
                    if (!IsValidLength(numbers))
                    {
                        Console.WriteLine("Number length can't be more than 10 digits.");
                    }
                    else
                    {
                        sum = SumOfListOfNumbers(numbers);
                    }
                }
                return sum;
            }
        }

        public bool IsValidLength(string numbers)
        {
            if (numbers.Length > 10)
                return false;
            else
                return true;
        }

        public int SumOfListOfNumbers(string numbers)
        {
            int sum = 0;
            var result = Regex.Matches(numbers, @"\d+");
            if (result.Count > 0)
            {
                for (int index = 0; index < result.Count; index++)
                {
                    sum = sum + Convert.ToInt32(result[index].Value);
                }
            }
            return sum;
        }

        public string NoOfNegativeNumbers(string numbers)
        {
            var result = Regex.Matches(numbers, @"-?\d+");
            StringBuilder builder = new StringBuilder();
            if (result.Count > 0)
            {

                for (int index = 0; index < result.Count; index++)
                {
                    if (result[index].Value.Contains("-"))
                    {
                        builder.Append(result[index].Value + ",");
                    }
                }
            }
            if (builder.Length != 0)
            {
                return builder.ToString().Remove(builder.ToString().Length - 1);
            }
            else
                return String.Empty;
        }
    }
}
