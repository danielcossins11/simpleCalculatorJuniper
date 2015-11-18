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
            string newInput = Input.Split(' ')[0];
            return int.Parse(newInput);
        }

        public int GetSecondInputNumber()
        {
            string newInput = Input.Split(' ')[2];
            return int.Parse(newInput);
        }

        public char GetOperator()
        {
            string newInput = Input.Split(' ')[1];
            return char.Parse(newInput);
        }
    }
}
