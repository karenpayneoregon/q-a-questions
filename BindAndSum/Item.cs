using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BindAndSum
{
    public class Item : INotifyPropertyChanged
    {
        private double _value1;
        private double _value2;

        public double Value1
        {
            get => _value1;
            set
            {
                _value1 = value;
                OnPropertyChanged();
            }
        }

        public double Value2
        {
            get => _value2;
            set
            {
                _value2 = value;
                OnPropertyChanged();
            }
        }

        public double Total => Value1 * Value2;

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
