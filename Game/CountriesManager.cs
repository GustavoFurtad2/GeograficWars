using System.Text.Json;

namespace GeograficWars.Game
{
    public class CountriesManager
    {
        private readonly GameState _state;

        public CountriesManager(GameState state)
        {
            _state = state;
        }

        public Country CreateCountry(Country country)
        {
            _state.Countries[country.CountryId] = country;

            return country;
        }

        public void RemoveCountry(string countryId)
        {
            if (_state.Countries[countryId] != null)
            {
                _state.Countries.Remove(countryId);
            }
        }

        public void LoadCountries()
        {
            string json = File.ReadAllText("wwwroot/countries.json");

            var options = new JsonSerializerOptions {IncludeFields = true};

            var countriesList = JsonSerializer.Deserialize<List<CountryData>>(json, options);

            foreach (var countryData in countriesList)
            {
                Country country = new Country(countryData);

                _state.Countries[country.CountryId] = country;
            }
        }

        public List<Country> GetCountries()
        {
            List<Country> countries = _state.Countries.Values.ToList();

            return countries;
        }
    }
}
