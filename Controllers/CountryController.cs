using Microsoft.AspNetCore.Mvc;
using MVC_Country.Services;

namespace MVC_Country.Controllers
{
    [Route("[controller]")]
    public class CountryController : Controller
    {

        [HttpGet("{countryName:regex()}")]
        [HttpGet("{countryName:regex()}/{cityName:regex()}")]
        [HttpGet("{countryName:regex()}/{cityName1:regex()}/{cityName2:regex()}")]
        public IActionResult GetPopulation(string countryName, string? cityName, string? cityName1, string? cityName2)
        {
            if (!string.IsNullOrEmpty(cityName1) && !string.IsNullOrEmpty(cityName2))
            {
                var population = PopulationService.GetPopulationForTwoCities(countryName, cityName1, cityName2);
                return Ok(population);
            }

            if (!string.IsNullOrEmpty(cityName))
            {
                var population = PopulationService.GetPopulationForSingleCity(countryName, cityName);
                return Ok(population);
            }
            else
            {
                var population = PopulationService.GetPopulationForCountry(countryName);
                return Ok(population);
            }
        }
    }
}
