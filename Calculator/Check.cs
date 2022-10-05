using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Check
    {
        internal void CheckNull(string operation, string secondNumber)
        {
            if (operation == "/" && secondNumber == "0")
            {
                Console.WriteLine("На ноль делить нельзя!");
                Program.StartCalc();
            }
        }
   }
}
