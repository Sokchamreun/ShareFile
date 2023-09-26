namespace SlashX.Net
{
    /// <summary>
    /// Bogo sort, also known as permutation sort, stupid sort, slow sort, shotgun sort or monkey sort, is a particularly ineffective sorting algorithm based on the generate and test paradigm.
    /// The algorithm successively generates permutations of its input until it finds one that is sorted. It is not useful for sorting, but may be used for educational purposes, to contrast it with other more realistic algorithms.
    /// </summary>
    public class BogoSort
    {
        private static bool IsSorted(ref int[] data)
        {
            int count = data.Length;

            while (--count >= 1)
                if (data[count] < data[count - 1]) return false;

            return true;
        }

        private static void Shuffle(ref int[] data)
        {
            int temp, rnd;
            Random rand = new Random();

            for (int i = 0; i < data.Length; ++i)
            {
                rnd = rand.Next(data.Length);
                temp = data[i];
                data[i] = data[rnd];
                data[rnd] = temp;
            }
        }
        public static void Sort(ref int[] data)
        {
            while (!IsSorted(ref data))
                Shuffle(ref data);
        }
        public static int[] Sort(int[] data)
        {
            int[] result = data.ToArray();
            Sort(ref result);
            return result;
        }
    }
}
