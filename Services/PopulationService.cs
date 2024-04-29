using MVC_Country.Data;

namespace MVC_Country.Services;

public static class PopulationService
{
    public static int GetPopulationForSingleCity(string countryName, string cityName)
    {
        if (CountryData.Countries.TryGetValue(countryName, out var country))
        {
            var city = country.Cities.SingleOrDefault(c => c.Name.Equals(cityName));
            if (city != null)
            {
                return city.Population;
            }
            throw new Exception("Wrong city name");
        }
        throw new Exception("Wrong country name");
    }

    public static int GetPopulationForTwoCities(string countryName, string cityName1, string cityName2)
    {
        if (CountryData.Countries.TryGetValue(countryName, out var country))
        {
            var cities = country.Cities.FindAll(c => c.Name.Equals(cityName1) || c.Name.Equals(cityName2));
            if (cities.Count != 2)
                throw new Exception("Wrong city name");
            var pop = 0;
            foreach (var city in cities)
                pop += city.Population;
            return pop;
        }
        throw new Exception("Wrong country name");
    }

    public static int GetPopulationForCountry(string countryName)
    {
        if (CountryData.Countries.TryGetValue(countryName, out var country))
        {
            return country.Population;
        }
        throw new Exception("Wrong country name");
    }
}