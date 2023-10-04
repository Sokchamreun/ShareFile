namespace SlashX.Net
{
    /// <summary>
    /// Counting sort is sorting algorithm based on keys between specific range. It works by counting the number of objects having distinct key values. 
    /// Then doing some arithmetic to calculate the position of each object in the output sequence.
    /// </summary>
    public class CountingSort
    {
        public static int[] Sort(int[] data, int min, int max)
        {
            int[] count = new int[max - min + 1];
            int z = 0;

            for (int i = 0; i < count.Length; i++)
                count[i] = 0;

            for (int i = 0; i < data.Length; i++)
                count[data[i] - min]++;

            for (int i = min; i <= max; i++)
            {
                while (count[i - min]-- > 0)
                {
                    data[z] = i;
                    ++z;
                }
            }
            return data;
        }
    }
}
