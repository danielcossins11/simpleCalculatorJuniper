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
            while (true)
            {
                Console.Write("[" + count + "]> ");
                input = Console.ReadLine();
                if(input == "exit" || input == "quit")
                {
                    Console.WriteLine("loggin out");
                    break;
                }
                try
                {
                    ProcessInput PI = new ProcessInput(input);
                    Evaluate ev = new Evaluate(PI.GetFirstInputNumber(), PI.GetOperator(), PI.GetSecondInputNumber());
                    Console.WriteLine("   = " + ev.Operate());
                }
                catch
                {
                    Console.WriteLine("oops!");
                }
                count++;
            }
        }
    }
}
