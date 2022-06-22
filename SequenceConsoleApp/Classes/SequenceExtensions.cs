using System.Linq;

namespace SequenceConsoleApp.Classes
{
    public static class SequenceExtensions
    {
        /// <summary>
        /// Get missing elements
        /// </summary>
        /// <param name="sequence"></param>
        /// <returns>missing elements</returns>
        /// <remarks>Run <seealso cref="IsSequenceBroken"/> first to determine if elements are missing</remarks>
        public static int[] SequenceFindMissing(this int[] sequence) =>
            sequence.Zip(sequence.Skip(1), (valueLeft, valueRight)
                => Enumerable.Range(valueLeft + 1, (valueRight - valueLeft) - 1))
                .SelectMany(item => item)
                .ToArray();

        /// <summary>
        /// Determine if the sequence has missing elements
        /// </summary>
        /// <param name="sequence">int array</param>
        /// <returns>true if missing elements, false if no missing elements</returns>
        public static bool IsSequenceBroken(this int[] sequence) =>
            sequence.Zip(sequence.Skip(1), (valueLeft, valueRight)
                => valueRight - valueLeft).Any(item => item != 1);
    }
}