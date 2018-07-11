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
            string numbers = "";
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
            return sum;
        }

    }
}
