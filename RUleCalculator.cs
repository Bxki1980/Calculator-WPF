using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_WindowsForm_
{
    interface RUleCalculator
    {
        int Sum(int number1, int number2);
        int Minus(int number1, int number2);
        int Multipule(int number1, int number2);
        int Divide(int number1, int number2);
    }
}
