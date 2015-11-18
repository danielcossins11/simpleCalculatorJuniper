using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Evaluate
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public char OP { get; set; }
        public Evaluate(int num1, char op, int num2)
        {
            Num1 = num1;
            Num2 = num2;
            OP = op;
        }

        public int Operate()
        {
            if(OP == '+')
            {
                return Add(Num1, Num2);
            }
            if(OP == '-')
            {
                return Subtact(Num1, Num2);
            }
            if(OP == '*')
            {
                return Multiply(Num1, Num2);
            }
            if(OP == '/')
            {
                return Divide(Num1, Num2);
            }
            if(OP == '%')
            {
                return Modulus(Num1, Num2);
            }
            throw new ArgumentException();
        }

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtact(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            return a / b;
        }

        public int Modulus(int a, int b)
        {
            return a % b;
        }
    }
}
