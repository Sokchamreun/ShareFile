namespace SlashX.Net
{
    /// <summary>
    /// /// <summary>
    /// The octal, or oct for short, is the base-8 positional numeral system, and uses the digits 0 to 7.
    /// </summary>
    /// </summary>
    public class OctalConverter
    {
        //// <summary>
        /// Convert from Octal to ASCII
        /// </summary>
        /// <param name="oct">110145154154157040127157162154144</param>
        /// <returns>Hello World</returns>
        public static string ToASCII(string oct)
        {
            string ascii = string.Empty;

            for (int i = 0; i < oct.Length; i += 3)
            {
                ascii += (char)ToDecimal(oct.Substring(i, 3));
            }

            return ascii;
        }

        /// <summary>
        /// Convert octal to decimal
        /// </summary>
        /// <param name="octal">23417</param>
        /// <returns>9999</returns>
        public static int ToDecimal(string octal)
        {
            int octLength = octal.Length;
            double dec = 0;

            for (int i = 0; i < octLength; ++i)
            {
                dec += ((byte)octal[i] - 48) * Math.Pow(8, ((octLength - i) - 1));
            }

            return (int)dec;
        }
    }
}
