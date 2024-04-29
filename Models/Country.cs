namespace MVC_Country.Models
{
    public class Country
    {
        public string? Name { get; set; }
        public List<City>? Cities { get; set; }
        public int Population { get; set; }
    }
}
