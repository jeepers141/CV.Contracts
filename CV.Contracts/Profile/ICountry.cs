namespace CV.Contracts.Profile
{
    public interface ICountry
    {
        string Name { get; set; }

        string ApiUrl { get; }

        string Code { set; }
    }
}