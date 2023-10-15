namespace UnitTests
{
    public class Calculator
    {
        public static int calculation(int firstOperand, int secondOperand, char operation)
        {
            int result;

            switch (operation)
            {
                case '+':
                    result = firstOperand + secondOperand;
                    break;
                case '-':
                    result = firstOperand - secondOperand;
                    break;
                case '*':
                    result = firstOperand * secondOperand;
                    break;
                case '/':
                    if (secondOperand != 0)
                    {
                        result = firstOperand / secondOperand;
                        break;
                    }
                    else
                    {
                        throw new ArithmeticException("Division by zero is not possible");
                    }
                default:
                    throw new ArgumentException("Unexpected value operator: " + operation);
            }
            return result;
        }

        public static double calculatingDiscount(double purchaseAmount, int discountAmount)
        {
            
            return purchaseAmount - ((Convert.ToDouble(discountAmount) / 100) * purchaseAmount);
        }
    }
}
