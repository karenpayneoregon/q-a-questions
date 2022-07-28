using System;

namespace Console1.Classes
{
    public class Counter
    {
        private readonly int threshold;
        private int total;

        public Counter(int passedThreshold)
        {
            threshold = passedThreshold;
        }

        public void Add(int value)
        {

            total += value;
            if (total >= threshold)
            {
                ThresholdReached?.Invoke(threshold, DateTime.Now);
            }
        }

        public delegate void ThresholdReachedEventArgs(int Threshold, DateTime TimeReached);
        public event ThresholdReachedEventArgs ThresholdReached;
    }


}
