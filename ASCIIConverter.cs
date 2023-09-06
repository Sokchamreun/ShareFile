namespace SlashX.Net
{
    public class ASCIIConverter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input">Hello World</param>
        /// <returns>0100100001100101011011000110110001101111001000000101011101101111011100100110110001100100</returns>
        public static string ToBinary(string input)
        {
            string bin = string.Empty;

            for (int i = 0; i < input.Length; ++i)
            {
                string cBin = DecimalConverter.ToBinary(input[i]);

                if (cBin.Length < 8)
                    cBin = cBin.PadLeft(8, '0');

                bin += cBin;
            }

            return bin;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="str">Hello World</param>
        /// <returns>110145154154157040127157162154144</returns>
        public static string ToOctal(string str)
        {
            string oct = string.Empty;

            for (int i = 0; i < str.Length; ++i)
            {
                string cOct = DecimalConverter.ToOctal(str[i]);

                if (cOct.Length < 3)
                    cOct = cOct.PadLeft(3, '0');

                oct += cOct;
            }

            return oct;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="str">Hello World</param>
        /// <returns>072101108108111032087111114108100</returns>
        public static string ToDecimal(string str)
        {
            string dec = string.Empty;

            for (int i = 0; i < str.Length; ++i)
            {
                string cDec = ((byte)str[i]).ToString();

                if (cDec.Length < 3)
                    cDec = cDec.PadLeft(3, '0');

                dec += cDec;
            }

            return dec;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="str">Hello World</param>
        /// <returns>48656C6C6F20576F726C64</returns>
        public static string ToHexa(string str)
        {
            string hex = string.Empty;

            for (int i = 0; i < str.Length; ++i)
            {
                string chex = DecimalConverter.ToHexa(str[i]);

                if (chex.Length == 1)
                    chex = chex.Insert(0, "0");

                hex += chex;
            }

            return hex;
        }
    }
}
