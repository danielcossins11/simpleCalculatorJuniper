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
        public bool IsGettingConstant { get; set; }
        public ProcessInput(string input)
        {
            Input = input;
        }

        public int GetFirstInputNumber()
        {
            try
            {
                string newInput = Input.Split(GetOperator())[0].Trim();
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
                string newInput = Input.Split(GetOperator())[1].Trim();
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
                    if (Input[i] == '+' || Input[i] == '-' || Input[i] == '*' || Input[i] == '/' || Input[i] == '%' || Input[i] == '=')
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

        public char GetConstant()
        {
            string constantInput = Input.Trim();
            if (constantInput.Length == 1 && Char.IsLetter(char.Parse(constantInput)))
            {
                IsGettingConstant = true;
                return char.Parse(constantInput);
            }

            string newInput = Input.Split(GetOperator())[0].Trim();
            char op = char.Parse(newInput);
            if (Char.IsLetter(op))
            {
                return op;
            }
            else
            {
                throw new FormatException();
            }
        }

        public List<char> GetConstantInEquation()
        {
            List<char> constList = new List<char>();
            for(int i=0; i<Input.Length; i++)
            {
                if (Char.IsLetter(Input[i]))
                {
                    constList.Add(Input[i]);
                }
            }
            return constList;
        }
    }
}
