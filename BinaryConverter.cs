namespace SlashX.Net
{
    public class BinaryConverter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bin">0100100001100101011011000110110001101111001000000101011101101111011100100110110001100100</param>
        /// <returns>Hello World</returns>
        public static string ToASCII(string bin)
        {
            string ascii = string.Empty;

            for (int i = 0; i < bin.Length; i += 8)
            {
                ascii += (char)ToDecimal(bin.Substring(i, 8));
            }

            return ascii;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bin">10011100001111</param>
        /// <returns>9999</returns>
        public static int ToDecimal(string bin)
        {
            int binLength = bin.Length;
            double dec = 0;

            for (int i = 0; i < binLength; ++i)
            {
                dec += ((byte)bin[i] - 48) * Math.Pow(2, ((binLength - i) - 1));
            }

            return (int)dec;
        }

    }
}
