using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesCalculator
{
    internal class Calculus : ICalculate, IResult
    { 
        public void Welcome()
        {
            Console.WriteLine($"Welcome to Smart Calculator. HURA !!!!");
            GetNumber();

            static void Add(decimal number1, decimal number2)
            {
                decimal addresult = number1 + number2;
                Console.WriteLine($"Addition result: {addresult}.");
            }
            static void Substract(decimal number1, decimal number2)
            {
                decimal subresult = number1 - number2;
                Console.WriteLine($"Substraction result: {subresult}.");
            }
            static void Multiplicate(decimal number1, decimal number2)
            {
                decimal mulresult = number1 * number2;
                Console.WriteLine($"Multiplicate result: {mulresult}.");
            }
            static void Divide(decimal number1, decimal number2)
            {
                decimal divresult = number1 / number2;
                Console.WriteLine($"Division result: {divresult}.");
            }
            static void Percentage(decimal number1, decimal number2)
            {
                decimal perresult = (number1 / number2) * 100;
                Console.WriteLine($"Percent result: {perresult} %.");
            }
            static void GetNumber()
            {
                Console.WriteLine("Number 1: ");
                decimal number1 = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Number 2: ");
                decimal number2 = decimal.Parse(Console.ReadLine());
                Add(number1, number2);
                Substract(number1, number2);
                Multiplicate(number1, number2);
                Divide(number1, number2);
                Percentage(number1, number2);
            }
        }
        public void Result()
        {
            Console.WriteLine($"Smart Calculus End");
        }
    }
}
