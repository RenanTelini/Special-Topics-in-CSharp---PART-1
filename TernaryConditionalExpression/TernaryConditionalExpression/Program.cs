using System;

namespace TernaryConditionalExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            double price = 34.5;
            double discount;

            //With if else
            if (price < 20.0)
            {
                discount = price * 0.1;
            }
            else
            {
                discount = price * 0.05;
            }
            Console.WriteLine(discount);

            //with Ternary Conditional Expression
            double price1 = 34.5;
            double discount1 = (price1 < 20.0) ? price1 * 0.1 : price1 * 0.05;
            Console.WriteLine(discount1);
        }
    }
}