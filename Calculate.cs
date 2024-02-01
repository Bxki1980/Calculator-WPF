using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_WindowsForm_
{
    class Calculate : RUleCalculator
    {
        public int Divide(int number1, int number2)
        {
            return number1 / number2;
        }

        public int Minus(int number1, int number2)
        {
            return number1 - number2;
        }

        public int Multipule(int number1, int number2)
        {
            return number1 * number2;
        }

        public int Sum(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}
