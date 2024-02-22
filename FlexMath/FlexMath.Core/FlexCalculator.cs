namespace FlexMath.Core
{
    public class FlexCalculator
    {
        private readonly IStringToNumberConvertor _stringToNumberConverter;

        public FlexCalculator(IStringToNumberConvertor stringToNumberConverter)
        {
            _stringToNumberConverter = stringToNumberConverter;
        }

        public double Add(double left, double right)
        {
            return left + right;
        }

        public double Add(double left, string right)
        {
            var parsedRight = ConvertToNumber(right);

            return left + parsedRight;
        }

        public double Add(string left, string right)
        {
            var parsedLeft = ConvertToNumber(left);

            var parsedRight = ConvertToNumber(right);

            return parsedLeft + parsedRight;
        }

        public double Subtract(double left, double right)
        {
            return left - right;
        }

        public double Subtract(double left, string right)
        {
            var parsedRight = ConvertToNumber(right);

            return left - parsedRight;
        }

        public double Subtract(string left, double right)
        {
            var parsedLeft = ConvertToNumber(left);

            return parsedLeft - right;
        }

        public double Subtract(string left, string right)
        {
            var parsedLeft = ConvertToNumber(left);

            var parsedRight = ConvertToNumber(right);

            return parsedLeft - parsedRight;
        }

        public double Multiply(double left, double right)
        {
            return left * right;
        }

        public double Multiply(double left, string right)
        {
            var parsedRight = ConvertToNumber(right);

            return left * parsedRight;
        }

        public double Multiply(string left, string right)
        {
            var parsedLeft = ConvertToNumber(left);

            var parsedRight = ConvertToNumber(right);

            return parsedLeft * parsedRight;
        }

        public double Divide(double left, double right)
        {
            if (right == 0)
            {
                throw new ArgumentException("Cannot divide by zero.");
            }

            return left / right;
        }

        public double Divide(double left, string right)
        {
            var parsedRight = ConvertToNumber(right);

            if (parsedRight == 0)
            {
                throw new ArgumentException("Cannot divide by zero.");
            }

            return left / parsedRight;
        }

        public double Divide(string left, double right)
        {
            if (right == 0)
            {
                throw new ArgumentException("Cannot divide by zero.");
            }

            var parsedLeft = ConvertToNumber(left);

            return parsedLeft / right;
        }

        public double Divide(string left, string right)
        {
            var parsedLeft = ConvertToNumber(left);

            var parsedRight = ConvertToNumber(right);

            if (parsedRight == 0)
            {
                throw new ArgumentException("Cannot divide by zero.");
            }

            return parsedLeft / parsedRight;
        }

        private double ConvertToNumber(string value)
        {
            if (!int.TryParse(value.ToString(), out int parsedValue))
            {
                return _stringToNumberConverter.Convert(value);
            }

            return parsedValue;
        }
    }
}
