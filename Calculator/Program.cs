using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string strExp = string.Empty;
            double dblResult = 0;

            Console.WriteLine("===========================================Welcome===========================================");
            Console.WriteLine("Rule:");
            Console.WriteLine("1. Accept operation for Addition, Substraction, Multiplication, Division");
            Console.WriteLine("2. Expression should only contain numbers, decimal point, +, -, *, /, (, )");
            Console.WriteLine("3. Negative and decimal values are allowed to be entered directly, eg. -1+-2.1, 1.5/-2");
            Console.WriteLine("4. Multiplication can be done as eg. 1*-2, 1(-2)");
            Console.WriteLine("5. Enter the expression as eg. 1 + ( 2.5 * 3 - ( 4 / 5.7 ) - 6.01 ) + 7");
            Console.WriteLine("=============================================================================================");
            Console.WriteLine("");


            while (true)
            {
                try
                {
                    Console.Write("Enter a mathematical expression to compute: ");
                    strExp = Console.ReadLine();
                    if (!string.IsNullOrEmpty(strExp))
                    {
                        dblResult = clsCompute.calculate(strExp);
                        Console.WriteLine("Answer: {0}", dblResult);
                    }
                    else
                        throw new Exception("No expression entered. Please enter again...");

                    Console.WriteLine("");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    Console.WriteLine("");
                }
            }
        }
    }
}
