using System;

namespace Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            

            


        }
        static int Calculate(int firstOperand, int secondOperand, char mathOperator)
        {
            switch (mathOperator)
            {
                case (char)Operand.ADDITION:
                    return firstOperand + secondOperand;
                case (char)Operand.DIVISION:
                    return firstOperand - secondOperand;
                case (char)Operand.MULTIPLICATION:
                    return firstOperand * secondOperand;
                case (char)Operand.SUBTRACTION:
                    if (secondOperand != 0)
                        return firstOperand / secondOperand;
                    else
                        throw new Exception("Can not divide by 0");
                default:
                    throw new Exception("Unsupported operation");
            }
        }
        public enum Operand{
            ADDITION = '+',
            SUBTRACTION = '-',
            MULTIPLICATION = '*',
            DIVISION = '/'
        }

    }
    
}
