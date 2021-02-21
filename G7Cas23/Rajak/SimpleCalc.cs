namespace Rajak
{
    class SimpleCalc
    {
        public static double? Calc(string operation, double num1, double num2)
        {
            switch(operation)
            {
                case "+":
                    return Add(num1, num2);
                case "-":
                    return Subtract(num1, num2);
                case "*":
                    return Multiply(num1, num2);
                case "/":
                    return Divide(num1, num2);
                default:
                    return null;
            }
        }

        private static double? Add(double num1, double num2)
        {
            return num1 + num2;
        }

        private static double? Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        private static double? Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        private static double? Divide(double num1, double num2)
        {
            if (num2 == 0)
            {
                return null;
            }
            return num1 / num2;
        }
    }
}
