namespace CV.Contracts.Profile
{
    public class Country : ICountry
    {
        public string Name { get; set; }
        public string ApiUrl => "https://www.countryflags.io/{Code}/"; 
        public string Code { private get; set; }
    }
}