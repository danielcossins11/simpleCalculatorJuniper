using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Constant
    {
        public char Name { get; set; }
        public int Number { get; set; }
        public Constant(char chrName, int numName)
        {
            Name = chrName;
            Number = numName;
        }
    }
}
