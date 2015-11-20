using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Constant
    {
        public Dictionary<char, int> Constants = new Dictionary<char, int>();
        public string Input { get; set; }
        public int Output { get; set; }
        public Constant()
        {

        }
        public Constant(string input)
        {
            Input = input;
        }

        public void ChangeExpression(string input)
        {
            Input = input;
        }

        public void AddToConstants(char constant, int value)
        {
            if (!IsInList(constant))
            {
                Constants.Add(constant, value);
            }
        }

        public int GetValueOf(char constant)
        {
            if (IsInList(constant))
            {
                return Constants[Char.ToLower(constant)];
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public bool IsInList(char constant)
        {
            if (Constants.ContainsKey(constant))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
