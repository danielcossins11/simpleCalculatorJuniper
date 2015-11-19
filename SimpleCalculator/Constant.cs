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
        //public Constant(char chrName, int numName)
        //{
        //    Name = chrName;
        //    Number = numName;
        //}

        public void AddToConstants(char constant, int value)
        {
            //bool isInList = false;
            //for(int i=0; i<Constants.Count; i++)
            //{
            //    if(Constants[constant] != null)
            //    {
            //        isInList = true;
            //        break;
            //    }
            //}
            //if (!isInList)
            //{
            //    Constants.Add(constant, value);
            //}

            try {
                var test = Constants[constant];
            }
            catch
            {
                Constants.Add(constant, value);
            }
        }
    }
}
