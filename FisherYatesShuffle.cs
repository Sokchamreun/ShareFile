namespace SlashX.Net
{
    public class FisherYatesShuffle
    {
        /// <summary>
        /// The algorithm takes a list of all the elements of the sequence, and continually determines 
        /// the next element in the shuffled sequence by randomly drawing an element from the list until no elements remain
        /// int[] data = { 486, 87, 522, 111, 894, 371, 1, 39 };
        /// int[] retVal = FisherYatesShuffle(data);
        /// </summary>
        /// <param name="data"></param>
        /// <returns>retVal: { 371, 486, 39, 894, 111, 522, 87, 1 }</returns>
        public static int[] Get(int[] data)
        {
            int[] retVal = new int[data.Length];
            int[] ind = new int[data.Length];
            int index;
            Random rand = new();

            for (int i = 0; i < data.Length; ++i)
                ind[i] = 0;

            for (int i = 0; i < data.Length; ++i)
            {
                do
                {
                    index = rand.Next(data.Length);
                } while (ind[index] != 0);

                ind[index] = 1;
                retVal[i] = data[index];
            }

            return retVal;
        }
    }
}
