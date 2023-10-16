﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace ForumQuestion2023.Models;

public partial class Products : INotifyPropertyChanged
{
    private string _productName;
    private decimal? _currentQuantity;
    private bool _selected;

    [NotMapped]
    public bool Selected
    {
        get => _selected;
        set
        {
            if (value == _selected) return;
            _selected = value;
            OnPropertyChanged();
        }
    }

    public int Id { get; set; }

    public string ProductName
    {
        get => _productName;
        set
        {
            if (value == _productName) return;
            _productName = value;
            OnPropertyChanged();
        }
    }

    public decimal? CurrentQuantity
    {
        get => _currentQuantity;
        set
        {
            if (value == _currentQuantity) return;
            _currentQuantity = value;
            OnPropertyChanged();
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}