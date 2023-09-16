namespace SlashX.Net
{
    public class BinarySearch
    {
        public static int Search(int[] data, int value)
        {
            int low = 0, high = data.Length - 1, midpoint;

            while (low <= high)
            {
                midpoint = low + (high - low) / 2;

                if (value == data[midpoint])
                    return midpoint;
                else if (value < data[midpoint])
                    high = midpoint - 1;
                else
                    low = midpoint + 1;
            }

            return -1;
        }
    }
}
