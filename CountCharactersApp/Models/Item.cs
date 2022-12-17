namespace CountCharactersApp.Models
{
    public class Item
    {
        public char Character { get; set; }
        public int Occurrences { get; set; }
        public int Code { get; set; }
        public override string ToString() => $"{Character} - {Occurrences}";

        public void Deconstruct(out char letter, out int occurrences, out int code)
        {
            letter = Character;
            occurrences = Occurrences;
            code = Code;
        }
        public void Deconstruct(out char character, out int occurrences)
        {
            character = Character;
            occurrences = Occurrences;
        }
    }
}