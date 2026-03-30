namespace AutoService.Models
{
    public class Car
    {
        public int    Id           { get; set; }
        public string Brand        { get; set; }
        public string Model        { get; set; }
        public int    Year         { get; set; }
        public string LicensePlate { get; set; }
        public int    ClientId     { get; set; }

        // Populated via JOIN for display/reporting
        public string ClientName   { get; set; }
    }
}
