namespace SlashX.Net
{
    public class DecimalConverter
    {
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
