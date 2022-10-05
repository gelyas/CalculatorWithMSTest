using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
   public class Calc
    {
        static float result = 0;

        public float CountNum(string firstNumber,
        string secondNumber,
        string operation) 
        {
           switch (operation)
            {
                case "-":
                    result = float.Parse(firstNumber) - float.Parse(secondNumber);
                    break;

                case "+":
                    result = float.Parse(firstNumber) + float.Parse(secondNumber);
                    break;

                case "/":
                    result = float.Parse(firstNumber) / float.Parse(secondNumber);
                    break;

                case "*":
                    result = float.Parse(firstNumber) * float.Parse(secondNumber);
                    break;
            }

            return result;
        }
    }
}
