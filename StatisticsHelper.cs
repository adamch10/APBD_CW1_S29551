using System;

namespace ApbdGit
{
    public class StatisticsHelper
    {
        public void ProcessData(int[] data)
        {
            if (data == null || data.Length == 0)
            {
                throw new ArgumentException("Data array cannot be null or empty.");
            }
        }
    }
}