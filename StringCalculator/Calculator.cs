using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class Calculator
    {
        static void Main(string[] args)
        {
            //string numbers = "";
            string numbers = "1\n2,3,1\n2,3,1\n2,3,1\n2,3,1\n2,3";
            Console.Write("                  String Calculator \n************************************************\n\n");
            Calculator calculator = new Calculator();
            numbers = calculator.Add(numbers).ToString();
            Console.WriteLine(numbers);
            Console.ReadLine();
        }

        public int Add(string numbers)
        {
            int sum = 0;

            if (String.IsNullOrWhiteSpace(numbers))
            {
                sum = 0;
            }
            else
            {
                if (!IsValidLength(numbers))
                {
                    Console.WriteLine("Number length can't be more than 10 digits.");
                }
            }
            return sum;
        }

        public bool IsValidLength(string numbers)
        {
            if (numbers.Length > 10)
                return false;
            else
                return true;
        }


    }
}
