using System;
using System.Text.RegularExpressions;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {


            decimal num, binary_val, decimal_val = 0, base_val = 1, rem;
            Console.Write("Enter a Binary Number(1s and 0s) : ");
            string input = Console.ReadLine();

            try
            {
                bool _validInput = true;
                foreach (char c in input.ToCharArray())
                {
                    if (!(c == '0' || c == '1'))
                    {
                        Console.Write("\nInvalid Input. " + input);
                        _validInput = false;
                        break;
                        Console.ReadLine();

                    }
                }
                if (_validInput)
                {
                    num = decimal.Parse(input);
                    binary_val = num;
                    while (num > 0)
                    {
                        rem = num % 10;
                        decimal_val = decimal_val + rem * base_val;
                        num = num / 10;
                        base_val = base_val * 2;
                    }

                    Console.Write("The Binary Number is : " + binary_val);
                    Console.Write("\nIts Decimal Equivalent is : " + Decimal.Round(decimal_val));

                }
            }
            catch (FormatException ex)
            {

                Console.Write("Please refer the exception : " + ex.Message);
                Console.ReadLine();
            }

        }
    }
}
