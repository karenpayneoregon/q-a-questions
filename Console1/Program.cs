using System;
using Console1.Classes;

namespace Console1
{
    partial class Program
    {
        private static bool _continue = true;
        static void Main(string[] args)
        {
            Counter counter = new(4);
            counter.ThresholdReached += OnThresholdReached;

            // try and go passed Threshold
            for (int index = 0; index < 15; index++)
            {
                if (_continue)
                {
                    counter.Add(index);
                }
                
            }

            Console.ReadLine();

        }

        private static void OnThresholdReached(int threshold, DateTime timeReached)
        {
            Console.WriteLine($"The threshold of {threshold} was reached at {timeReached}.");
            _continue = false;
        }
    }
}
