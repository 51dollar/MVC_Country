using MVC_Country.Models;

namespace MVC_Country.Data
{
    public class CountryData
    {
        public static Dictionary<string, Country> Countries = new()
    {

        { "Italy", new()
        {
            Name = "Italy", Population = 58853482, Cities =
            [
                new() { Name = "Rome", Population = 2761632 },
                new() { Name = "Venice", Population = 261905 },
            ]
        }},
        { "China", new()
        {
            Name = "China", Population = 1409670000
        }},

    };
    }
}