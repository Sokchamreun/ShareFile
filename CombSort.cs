namespace SlashX.Net
{
    /// <summary>
    /// Comb sort is sorting algorithm and it is a variant of Bubble sort,
    /// the Comb Sort increases the gap used in comparisons and exchanges.
    /// </summary>
    public class CombSort
    {
        public static int[] Sort(int[] data)
        {
            double gap = data.Length;
            bool swaps = true;

            while (gap > 1 || swaps)
            {
                gap /= 1.247330950103979;

                if (gap < 1)
                    gap = 1;

                int i = 0;
                swaps = false;

                while (i + gap < data.Length)
                {
                    int igap = i + (int)gap;

                    if (data[i] > data[igap])
                    {
                        int temp = data[i];
                        data[i] = data[igap];
                        data[igap] = temp;
                        swaps = true;
                    }

                    ++i;
                }
            }
            return data;
        }
    }
}
