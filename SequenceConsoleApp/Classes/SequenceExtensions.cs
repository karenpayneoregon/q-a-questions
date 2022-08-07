using System;
using System.Collections.Immutable;
using System.Linq;

namespace SequenceConsoleApp.Classes
{
    public static class SequenceExtensions
    {

        public static int[] FindMissing(this int[] sequence) =>
            sequence
                .Sort()
                .Zip(sequence.Skip(1), (valueLeft, valueRight) 
                    => Enumerable.Range(valueLeft + 1, (valueRight - valueLeft) - 1))
                .SelectMany(item => item)
                .ToArray();


        public static int[] Missing(this int[] sequence)
        {
            Array.Sort(sequence);
            return Enumerable.Range(sequence.First(), sequence.Last()).Except(sequence).ToArray();
        }

        public static int[] Missing1(this int[] sequence)
        {
            Array.Sort(sequence);
            return Enumerable
                .Range(1, sequence[^1])
                .Except(sequence)
                .ToArray();
        }


        /// <summary>
        /// Determine if the sequence has missing elements
        /// </summary>
        /// <param name="sequence">int array</param>
        /// <returns>true if missing elements, false if no missing elements</returns>
        public static bool IsSequenceBroken(this int[] sequence)
        {
            return sequence.Sort().Zip(sequence.Skip(1), (valueLeft, valueRight)
                => valueRight - valueLeft).Any(item => item != 1);
        }

        public static int[] Sort(this int[] sender)
        {
            Array.Sort(sender);
            return sender;
        }
    }
}