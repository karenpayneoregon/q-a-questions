using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Demo1
{
    public class BindingListSpecial<T> : BindingList<T>
    {
        private readonly List<T> _baseList;

        public BindingListSpecial() : this(new List<T>()) { }

        public BindingListSpecial(List<T> baseList) : base(baseList)
        {
            _baseList = baseList ?? throw new ArgumentNullException();
        }

        public void AddRange(IEnumerable<T> values)
        {
            if (values is ICollection<T> collection)
            {
                int requiredCapacity = Count + collection.Count;
                if (requiredCapacity > _baseList.Capacity)
                {
                    _baseList.Capacity = requiredCapacity;
                }
            }

            bool restore = RaiseListChangedEvents;

            try
            {
                RaiseListChangedEvents = false;
                foreach (T value in values)
                {
                    Add(value); // We cant call _baseList.Add, otherwise Events wont get hooked.
                }
            }
            finally
            {
                RaiseListChangedEvents = restore;
                if (RaiseListChangedEvents)
                    ResetBindings();
            }
        }
    }
}