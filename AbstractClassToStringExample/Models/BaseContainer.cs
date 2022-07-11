namespace AbstractClassToStringExample.Models
{
    public abstract class BaseContainer
    {
        public string Name { get; set; }
        public string SerialNumber { get; set; }
        public override string ToString() => Name;
    }
}
