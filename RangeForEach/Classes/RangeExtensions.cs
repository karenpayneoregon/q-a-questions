﻿using System.Collections;

namespace RangeForEach.Classes
{
    public static class RangeExtensions
    {
        /// <summary>
        /// Returns an enumerator that iterates through a <seealso cref="Range"/>.
        /// </summary>
        /// <param name="range">Range to iterate e.g. 4..8</param>
        public static RangeEnumerator GetEnumerator(this Range range)
        {

            if (range.Start.IsFromEnd || range.End.IsFromEnd)
            {
                throw new ArgumentException(nameof(range));
            }

            return new RangeEnumerator(range.Start.Value, range.End.Value);

        }

        public struct RangeEnumerator : IEnumerator<int>
        {
            private readonly int _end;
            private int _current;

            public RangeEnumerator(int start, int end)
            {
                _current = start - 1;
                _end = end;
            }

            public int Current => _current;
            object IEnumerator.Current => Current;

            public bool MoveNext() => ++_current < _end;

            public void Dispose() { }
            public void Reset()
            {
                throw new NotImplementedException();
            }
        }
    }
}