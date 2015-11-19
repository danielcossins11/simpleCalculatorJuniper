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
            if (!IsInList(constant))
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

        public List<int> GetValuesOfAllConstants(List<char> constantsList)
        {
            List<int> values = new List<int>();
            for(int i=0; i<constantsList.Count; i++)
            {
                values.Add(GetValueOf(constantsList[i]));
            }
            return values;
        }
    }
}
