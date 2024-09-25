namespace Methods
{
    public class MathOperations
    {
        public static int Power(int x, int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("The exponent must be a non-negative integer.");
            }

            int result = 1;
            for (int i = 0; i < n; i++)
            {
                result *= x;
            }
            return result;
        }
    }
}
