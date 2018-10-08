namespace CV.Contracts.Profile
{
    public interface IContact
    {
        ContactDetails ContactDetails { get; set; }

        SocialMedia SocialMedia { get; set; }
    }
}