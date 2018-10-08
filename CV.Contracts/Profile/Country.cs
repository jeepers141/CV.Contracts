namespace CV.Contracts.Profile
{
    public class Country : ICountry
    {
        public Country(string code, string name)
        {
            Code = code;
            Name = name;
        }

        public string Code { get; private set; }
        public string Name { get; private set; }
        public string ApiUrl => $"https://www.countryflags.io/{Code}/"; 
    }
}