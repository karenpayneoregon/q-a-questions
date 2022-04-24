namespace Demo
{
    public class Phone
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public override string ToString() => PhoneNumber;
    
    }
}