namespace SlashX.Net
{
    /// <summary>
    /// Cocktail shaker sort, also known as bidirectional bubble sort, cocktail sort, shaker sort, ripple sort, shuffle sort, 
    /// or shuttle sort, is a variation of bubble sort that is both a stable sorting algorithm and a comparison sort. 
    /// The algorithm differs from a bubble sort in that it sorts in both directions on each pass through the list. 
    /// This sorting algorithm is only marginally more difficult to implement than a bubble sort, and solves the problem of turtles 
    /// in bubble sorts. It provides only marginal performance improvements, and does not improve asymptotic performance; like the bubble sort.
    /// </summary>
    public class CocktailShakerSort
    {
        private static void Swap(ref int a, ref int b)
        {
            a ^= b;
            b ^= a;
            a ^= b;
        }

        public static int[] Sort(int[] data)
        {
            while (true)
            {
                bool flag;
                int[] start = { 1, data.Length - 1 };
                int[] end = { data.Length, 0 };
                int[] inc = { 1, -1 };

                for (int it = 0; it < 2; ++it)
                {
                    flag = true;

                    for (int i = start[it]; i != end[it]; i += inc[it])
                    {
                        if (data[i - 1] > data[i])
                        {
                            Swap(ref data[i - 1], ref data[i]);
                            flag = false;
                        }
                    }

                    if (flag)
                        return data;
                }
            }
        }
    }
}
