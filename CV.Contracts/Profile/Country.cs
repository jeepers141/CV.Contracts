namespace CV.Contracts.Profile
{
    public class Country : ICountry
    {
        private readonly string _code;

        public Country(string code, string name)
        {
            _code = code;
            Name = name;
        }

        public string Name { get; private set; }
        public string ApiUrl => $"https://www.countryflags.io/{_code}/"; 
    }
}