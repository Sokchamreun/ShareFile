namespace SlashX.Net
{
    /// <summary>
    /// The Mersenne Twister is a pseudorandom number generator (PRNG). 
    /// It is by far the most widely used general-purpose PRNG.
    /// Its name derives from the fact that its period length is chosen to be a Mersenne prime.
    /// Seed(15858);
    /// uint rand = Random()
    /// </summary>
    public class MersenneTwister
    {
        private const uint N = 624;
        private const uint M = 397;
        private const uint K = 0x9908B0DFU;

        private static uint[] state = new uint[N + 1];
        private static uint nextRand;
        private static int left = -1;

        private static uint HighestBit(uint u)
        {
            return ((u) & 0x80000000U);
        }

        private static uint LowestBit(uint u)
        {
            return ((u) & 0x00000001U);
        }

        private static uint LowestBits(uint u)
        {
            return ((u) & 0x7FFFFFFFU);
        }

        private static uint MixBits(uint u, uint v)
        {
            return (HighestBit(u) | LowestBits(v));
        }

        private static uint Reload()
        {
            uint p0 = 0;
            uint p2 = 2;
            uint pM = M;
            uint s0;
            uint s1;
            int j;

            if (left < -1)
            {
                Seed(4357U);
            }

            left = (int)(N - 1);
            nextRand = state[1];

            for (s0 = state[0], s1 = state[1], j = (int)(N - M + 1); Convert.ToBoolean(--j); s0 = s1, s1 = state[p2++])
            {
                state[p0++] = state[pM++] ^ (MixBits(s0, s1) >> 1) ^ (Convert.ToBoolean(LowestBit(s1)) ? K : 0U);
            }

            for (pM = 0, j = (int)M; Convert.ToBoolean(--j); s0 = s1, s1 = state[p2++])
            {
                state[p0++] = state[pM++] ^ (MixBits(s0, s1) >> 1) ^ (Convert.ToBoolean(LowestBit(s1)) ? K : 0U);
            }

            s1 = state[0];
            state[p0] = state[pM] ^ (MixBits(s0, s1) >> 1) ^ (Convert.ToBoolean(LowestBit(s1)) ? K : 0U);
            s1 ^= (s1 >> 11);
            s1 ^= (s1 << 7) & 0x9D2C5680U;
            s1 ^= (s1 << 15) & 0xEFC60000U;

            return (s1 ^ (s1 >> 18));
        }

        public static void Seed(uint seed)
        {
            uint x = (seed | 1U) & 0xFFFFFFFFU;
            uint[] s = state;
            int j;
            int i = 0;

            for (left = 0, s[i++] = x, j = (int)N; Convert.ToBoolean(--j); s[i++] = (x *= 69069U) & 0xFFFFFFFFU) ;
        }

        public static uint Random()
        {
            uint y;

            if (--left < 0)
            {
                return Reload();
            }

            y = nextRand++;
            y ^= (y >> 11);
            y ^= (y << 7) & 0x9D2C5680U;
            y ^= (y << 15) & 0xEFC60000U;

            return (y ^ (y >> 18));
        }
    }
}
