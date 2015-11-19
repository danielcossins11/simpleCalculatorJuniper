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

        public void AddToConstants(char constant, int value)
        {
            try {
                var test = Constants[Char.ToLower(constant)];
            }
            catch
            {
                Constants.Add(constant, value);
            }
        }

        public int GetValueOf(char constant)
        {
            try {
                return Constants[Char.ToLower(constant)];
            }
            catch
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
