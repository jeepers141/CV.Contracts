namespace CV.Contracts.Profile
{
    public class Language : ILanguage
    {
        public string Proficiency { get; set; }
        public string Name => ToString();
    }
}