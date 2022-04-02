using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BasicReadWriteJson.Former
{
    public class Products1 : INotifyPropertyChanged
    {
        private string _productName;
        private int _productId;
        private int? _supplierId;
        private int? _categoryId;
        private string _quantityPerUnit;
        private decimal? _unitPrice;
        private short? _unitsInStock;
        private short? _unitsOnOrder;
        private short? _reorderLevel;
        private bool _discontinued;
        private DateTime? _discontinuedDate;

        public int ProductId
        {
            get => _productId;
            set => _productId = value;
        }

        public string ProductName
        {
            get => _productName;
            set
            {
                _productName = value;
                OnPropertyChanged();
            }
        }

        public int? SupplierId
        {
            get => _supplierId;
            set
            {
                _supplierId = value;
                OnPropertyChanged();
            }
        }

        public int? CategoryId
        {
            get => _categoryId;
            set
            {
                _categoryId = value;
                OnPropertyChanged();
            }
        }

        public string QuantityPerUnit
        {
            get => _quantityPerUnit;
            set
            {
                _quantityPerUnit = value;
                OnPropertyChanged();
            }
        }

        public decimal? UnitPrice
        {
            get => _unitPrice;
            set
            {
                _unitPrice = value;
                OnPropertyChanged();
            }
        }

        public short? UnitsInStock
        {
            get => _unitsInStock;
            set
            {
                _unitsInStock = value;
                OnPropertyChanged();
            }
        }

        public short? UnitsOnOrder
        {
            get => _unitsOnOrder;
            set
            {
                _unitsOnOrder = value;
                OnPropertyChanged();
            }
        }

        public short? ReorderLevel
        {
            get => _reorderLevel;
            set
            {
                _reorderLevel = value;
                OnPropertyChanged();
            }
        }

        public bool Discontinued
        {
            get => _discontinued;
            set
            {
                _discontinued = value;
                OnPropertyChanged();
            }
        }

        public DateTime? DiscontinuedDate
        {
            get => _discontinuedDate;
            set
            {
                _discontinuedDate = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}