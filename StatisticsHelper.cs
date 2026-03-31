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

        public double CalculateAverage(int[] data)
        {
            ProcessData(data); // u¿ywamy naszej walidacji
            double sum = 0;
            foreach (int val in data)
            {
                sum += val;
            }
            return sum / data.Length;
        }

        public int CalculateMax(int[] data)
        {
            ProcessData(data);
            int max = data[0];
            foreach (int val in data)
            {
                if (val > max) max = val;
            }
            return max;
        }
    }
}