namespace FlexMath.Core
{
    public class FlexCalculator
    {
        static readonly Dictionary<string, int> numberDictionary = new()
        {
            {"zero", 0},
            {"one", 1},
            {"two", 2},
            {"three", 3},
            {"four", 4},
            {"five", 5},
            {"six", 6},
            {"seven", 7},
            {"eight", 8},
            {"nine", 9}
        };

        public static double Add(double left, double right)
        {
            return left + right;
        }

        public static double Add(double left, string right)
        {
            var parsedRight = ConvertToNumber(right);

            return left + parsedRight;
        }

        public static double Add(string left, string right)
        {
            var parsedLeft = ConvertToNumber(left);

            var parsedRight = ConvertToNumber(right);

            return parsedLeft + parsedRight;
        }

        public static double Subtract(double left, double right)
        {
            return left - right;
        }

        public static double Subtract(double left, string right)
        {
            var parsedRight = ConvertToNumber(right);

            return left - parsedRight;
        }

        public static double Subtract(string left, double right)
        {
            var parsedLeft = ConvertToNumber(left);

            return parsedLeft - right;
        }

        public static double Multiply(double left, double right)
        {
            return left * right;
        }

        public static double Multiply(double left, string right)
        {
            var parsedRight = ConvertToNumber(right);

            return left * parsedRight;
        }

        public static double Divide(double left, double right)
        {
            if (right == 0)
            {
                throw new ArgumentException("Cannot divide by zero.");
            }

            return left / right;
        }

        public static double Divide(double left, string right)
        {
            if (!int.TryParse(right.ToString(), out int parsedRight))
            {
                if (!numberDictionary.TryGetValue(right.ToLower(), out parsedRight))
                {
                    throw new ArgumentException("Cannot divide by zero.");
                }
            }

            return left / parsedRight;
        }

        public static double Divide(string left, double right)
        {
            if (right == 0)
            {
                throw new ArgumentException("Cannot divide by zero.");
            }

            var parsedLeft = ConvertToNumber(left);

            return parsedLeft / right;
        }

        private static double ConvertToNumber(string value)
        {
            if (!int.TryParse(value.ToString(), out int parsedValue))
            {
                if (!numberDictionary.TryGetValue(value.ToLower(), out parsedValue))
                {
                    parsedValue = 0;
                }
            }

            return parsedValue;
        }
    }
}
