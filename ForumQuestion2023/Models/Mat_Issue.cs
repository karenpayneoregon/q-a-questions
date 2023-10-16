#nullable disable
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace ForumQuestion2023.Models;

public class MatIssue : INotifyPropertyChanged
{
    private bool _selected;
    private short _itemsId;
    private short _reportId;
    private int _mtoId;
    private decimal _qty;
    private string _remark;
    private string _subName;
    private byte? _wid;

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

    [Key]
    public int Id { get; set; }

    public short ItemsId
    {
        get => _itemsId;
        set => _itemsId = value;
    }

    public short ReportId
    {
        get => _reportId;
        set => _reportId = value;
    }

    public int MtoId
    {
        get => _mtoId;
        set => _mtoId = value;
    }

    public decimal Qty
    {
        get => _qty;
        set => _qty = value;
    }

    public string? Remark
    {
        get => _remark;
        set => _remark = value;
    }

    public string? SubName
    {
        get => _subName;
        set => _subName = value;
    }

    public byte? Wid
    {
        get => _wid;
        set => _wid = value;
    }
    public event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}