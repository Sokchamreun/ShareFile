namespace SlashX.Net
{
    /// <summary>
    /// get Greatest Common Divisor (GCD) or Least Common Multiple (LCM)
    /// </summary>
    public class CommonDivisorMultiple
    {
        /// <summary>
        /// The Greatest Common Divisor (GCD) of two whole numbers, 
        /// also called the Greatest Common Factor (GCF) and the Highest Common Factor (HCF),
        /// is the largest whole number that's a divisor (factor) of both of them
        /// </summary>
        public static int GetGCD(int left, int right)
        {
            while (left != 0 && right != 0)
            {
                if (left > right)
                    left %= right;
                else
                    right %= left;
            }
            return left | right;
        }

        /// <summary>
        /// The Least Common Multiple (LCM) of two or more integers is the smallest positive integer that is divisible by all the given numbers.
        /// </summary>
        public static int GetLCM(int left, int right)
        {
            return (left * right) / GetGCD(left, right);
        }
    }
}
