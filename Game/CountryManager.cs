using System.Text.Json;

namespace GeograficWars.Game
{
    public class CountryManager
    {
        
        public List<Country>? Countries { get; private set; }

        public CountryManager()
        {
            Countries = new List<Country>();
        }

        public void LoadCountries()
        {
            string json = File.ReadAllText("wwwroot/countries.json");

            Countries = JsonSerializer.Deserialize<List<Country>>(json);
        }

        public Country GetByName(string name)
        {
            return Countries.FirstOrDefault(c => c.Name == name);
        }
    }
}
