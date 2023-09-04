namespace SlashX.Net
{
    public class DecimalConverter
    {
        /// <summary>
        /// Convert from decimal number to ASCII
        /// </summary>
        /// <param name="dec">072101108108111032087111114108100</param>
        /// <returns>Hello World</returns>
        public static string ToASCII(string dec)
        {
            string ascii = string.Empty;

            for (int i = 0; i < dec.Length; i += 3)
            {
                ascii += (char)Convert.ToByte(dec.Substring(i, 3));
            }

            return ascii;
        }


        /// <summary>
        /// Convert from decimal to binary number
        /// </summary>
        /// <param name="dec">9999</param>
        /// <returns>10011100001111</returns>
        public static string ToBinary(int dec)
        {
            if (dec < 1) return "0";

            string binStr = string.Empty;

            while (dec > 0)
            {
                binStr = binStr.Insert(0, (dec % 2).ToString());
                dec /= 2;
            }

            return binStr;
        }
        public static string ToBinary(string dec)
            => ToBinary(Convert.ToInt32(dec));


        /// <summary>
        /// 
        /// </summary>
        /// <param name="dec">9999</param>
        /// <returns>270F</returns>
        public static string ToHexa(int dec)
        {
            if (dec < 1) return "0";

            int hex = dec;
            string hexStr = string.Empty;

            while (dec > 0)
            {
                hex = dec % 16;

                if (hex < 10)
                    hexStr = hexStr.Insert(0, Convert.ToChar(hex + 48).ToString());
                else
                    hexStr = hexStr.Insert(0, Convert.ToChar(hex + 55).ToString());

                dec /= 16;
            }

            return hexStr;
        }

        public static string ToHexa(string dec)
            => ToHexa(Convert.ToInt32(dec));


        /// <summary>
        /// 
        /// </summary>
        /// <param name="dec">9999</param>
        /// <returns></returns>
        public static string ToOctal(int dec)
        {
            if (dec < 1) return "0";

            string octStr = string.Empty;

            while (dec > 0)
            {
                octStr = octStr.Insert(0, (dec % 8).ToString());
                dec /= 8;
            }

            return octStr;
        }

        public static string ToOctal(string dec)
            => ToOctal(Convert.ToInt32(dec));
    }
}