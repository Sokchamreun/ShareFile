namespace SlashX.Net
{
    /// <summary>
    /// it improved variant of binary search. This search algorithm works on the probing position of the required value.
    /// For this algorithm to work properly, the data collection should be in sorted and equally distributed form.
    /// </summary>
    public class InterpolationSearch
    {
        public static int Search(int[] list, int data)
        {
            int  index = -1, lo = 0, mid, hi = list.Length - 1;

            while (lo <= hi)
            {
                mid = (int)(lo + (double)(hi - lo) / (list[hi] - list[lo]) * (data - list[lo]));

                if (list[mid] == data)
                {
                    index = mid;
                    break;
                }
                else
                {
                    if (list[mid] < data)
                        lo = mid + 1;
                    else
                        hi = mid - 1;
                }
            }

            return index;
        }
    }
}
