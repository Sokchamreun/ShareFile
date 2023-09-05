namespace SlashX.Net
{
    public class HexadecimalConverter
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hex">48656C6C6F20576F726C64</param>
        /// <returns>Hello World</returns>
        public static string ToASCII(string hex)
        {
            string ascii = string.Empty;

            for (int i = 0; i < hex.Length; i += 2)
            {
                ascii += (char)ToDecimal(hex.Substring(i, 2));
            }

            return ascii;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hex">270F</param>
        /// <returns>9999</returns>
        public static int ToDecimal(string hex)
        {
            hex = hex.ToUpper();

            int hexLength = hex.Length;
            double dec = 0;

            for (int i = 0; i < hexLength; ++i)
            {
                byte b = (byte)hex[i];

                if (b >= 48 && b <= 57)
                    b -= 48;
                else if (b >= 65 && b <= 70)
                    b -= 55;

                dec += b * Math.Pow(16, ((hexLength - i) - 1));
            }

            return (int)dec;
        }
    }
}
