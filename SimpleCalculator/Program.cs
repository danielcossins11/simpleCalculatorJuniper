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
                Console.Write("[" + count + "]> ");
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
                    PI.GetConstant();
                    if (PI.IsGettingConstant)
                    {
                        Console.WriteLine(PI.GetConstant() + "   = " + constant.GetValueOf(PI.GetConstant()));
                    }
                    else
                    {
                        try
                        {
                            constant.AddToConstants(PI.GetConstant(), PI.GetSecondInputNumber());
                            Console.WriteLine("    set " + PI.GetConstant() + " as " + constant.GetValueOf(PI.GetConstant()));
                        }
                        catch
                        {
                            Console.WriteLine("oops!");
                        }
                    }
                }
                count++;
            }
        }
    }
}
