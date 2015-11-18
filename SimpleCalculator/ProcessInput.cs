using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class ProcessInput
    {
        public string Input { get; set; }
        public ProcessInput(string input)
        {
            Input = input;
        }

        public int GetFirstInputNumber()
        {
            try
            {
                string newInput = Input.Split(GetOperator())[0].TrimEnd();
                return int.Parse(newInput);
            }
            catch
            {
                throw new FormatException();
            }
        }

        public int GetSecondInputNumber()
        {
            try
            {
                string newInput = Input.Split(GetOperator())[1].TrimStart();
                return int.Parse(newInput);
            }
            catch
            {
                throw new FormatException();
            }
        }

        public char GetOperator()
        {
            try
            {
                List<char> op = new List<char>();
                for (int i = 0; i < Input.Length; i++)
                {
                    if (Input[i] == '+' || Input[i] == '-' || Input[i] == '*' || Input[i] == '/' || Input[i] == '%')
                    {
                        op.Add(Input[i]);
                    }
                }
                if(op.Count == 1)
                {
                    return op[0];
                }
                else
                {
                    throw new FormatException();
                }
            }
            catch
            {
                throw new FormatException();
            }
        }
    }
}
