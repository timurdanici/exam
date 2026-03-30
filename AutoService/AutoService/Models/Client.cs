namespace AutoService.Models
{
    public class Client
    {
        public int    Id         { get; set; }
        public string LastName   { get; set; }
        public string FirstName  { get; set; }
        public string Phone      { get; set; }
        public string Address    { get; set; }

        public string FullName => $"{LastName} {FirstName}";

        public override string ToString() => FullName;
    }
}
