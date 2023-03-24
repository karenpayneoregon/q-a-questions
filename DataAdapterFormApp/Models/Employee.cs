using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DataAdapterFormApp.Models
{
    public class Employee : INotifyPropertyChanged
    {
        private int _id;
        private string _firstName;
        private string _lastName;
        private DateTime _hiredDate;

        public int Id
        {
            get => _id;
            set
            {
                if (value == _id) return;
                _id = value;
                OnPropertyChanged();
            }
        }

        public string FirstName
        {
            get => _firstName;
            set
            {
                if (value == _firstName) return;
                _firstName = value;
                OnPropertyChanged();
            }
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                if (value == _lastName) return;
                _lastName = value;
                OnPropertyChanged();
            }
        }

        public DateTime HiredDate
        {
            get => _hiredDate;
            set
            {
                if (value.Equals(_hiredDate)) return;
                _hiredDate = value;
                OnPropertyChanged();
            }
        }

        public override string ToString() => $"{Id,-5}";


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
