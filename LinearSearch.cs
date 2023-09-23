namespace SlashX.Net
{
    /// <summary>
    /// Linear search, also known as sequential search is an algorithm for finding a target value within a list. 
    /// It sequentially checks each element of the list for the target value until a match is found or until all the elements have been searched. 
    /// </summary>
    public class LinearSearch
    {
        public static int Search(int[] list, int data)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (data == list[i]) return i;
            }

            return -1;
        }
    }
}
