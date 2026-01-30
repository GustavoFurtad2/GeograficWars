namespace GeograficWars.Game
{
    public class Country
    {
        private readonly CountryData _countryData;

        public string CountryId { get; private set; } = Guid.NewGuid().ToString();

        public string OwnerId { get; private set; } = string.Empty;

        public Country(CountryData country)
        {
            _countryData = country;
        }

        public CountryData GetCountryData()
        {
            return _countryData;
        }

        public void SetOwner(string ownerId)
        {
            OwnerId = ownerId;
        }
    }
}
