namespace SlashX.Net
{
    /// <summary>
    /// Bubble Sort is the simplest sorting algorithm that works by repeatedly swapping the adjacent elements if they are in the wrong order. 
    /// This algorithm is not suitable for large data sets as its average and worst-case time complexity is quite high.
    /// </summary>
    public class BubbleSort
    {
        public static int[] Sort(int[] data)
        {
            for (int i = 1; i < data.Length; ++i)
            {
                for (int j = 0; j < data.Length - i; ++j)
                {
                    if (data[j] > data[j + 1])
                    {
                        data[j] ^= data[j + 1];
                        data[j + 1] ^= data[j];
                        data[j] ^= data[j + 1];
                    }
                }
            }
            return data;
        }
    }
}
