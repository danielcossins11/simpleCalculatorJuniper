using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator");
            int count = 0;
            string input;
            Constant constant = new Constant();
            while (true)
            {
                Console.Write("[{0}]> ", count);
                input = Console.ReadLine();
                if(input == "exit" || input == "quit")
                {
                    Console.WriteLine("loggin out");
                    break;
                }
                ProcessInput PI = new ProcessInput(input);
                try
                {
                    Evaluate ev = new Evaluate(PI.GetFirstInputNumber(), PI.GetOperator(), PI.GetSecondInputNumber());
                    Console.WriteLine("   = " + ev.Operate());
                }
                catch
                {
                    constant.ChangeExpression(input);
                    try
                    {
                        Console.WriteLine(constant.GetExpression());
                    }
                    catch
                    {
                        Console.WriteLine("Error! Try again . . .");
                    }
                }
                count++;
            }
        }
    }
}
