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
            string input = Console.ReadLine();
            ProcessInput PI = new ProcessInput(input);
            while(true)
            {
                input = Console.ReadLine();
                if(input == "exit" || input == "quit")
                {
                    Console.WriteLine("loggin out");
                    break;
                }
            }
        }
    }
}
