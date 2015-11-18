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
            int num;
            StringBuilder sb = new StringBuilder();
            string newInput;
            for(int i=0; i<Input.Length; i++)
            {
                if(Input[i] == ' ')
                {
                    break;
                }
                sb.Append(Input[i]);
            }
            newInput = sb.ToString();
            num = int.Parse(newInput);
            return num;
        }
    }
}
