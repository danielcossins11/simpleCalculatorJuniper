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

        public bool ValidInput()
        {
            string[] newStringArr = Input.Split(' ');
            if(newStringArr.Length == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetFirstInputNumber()
        {
            try
            {
                string newInput = Input.Split(' ')[0];
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
                string newInput = Input.Split(' ')[2];
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
                string newInput = Input.Split(' ')[1];
                return char.Parse(newInput);
            }
            catch
            {
                throw new FormatException();
            }
        }
    }
}
