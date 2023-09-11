namespace SlashX.Net
{
    public class ISOCRandom
    {
        public static int Generate(uint seed)
        {
            uint next = seed;
            int result;

            next *= 1103515245;
            next += 12345;
            result = (int)((uint)(next / 65536) % 2048);

            next *= 1103515245;
            next += 12345;
            result <<= 10;
            result ^= (int)((uint)(next / 65536) % 1024);

            next *= 1103515245;
            next += 12345;
            result <<= 10;
            result ^= (int)((uint)(next / 65536) % 1024);
            return result;
        }
    }
}
