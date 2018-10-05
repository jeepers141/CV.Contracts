using System;

namespace CV.Contracts.Profile
{
    public interface IProfile
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        ContactDetails ContactDetails { get; set; }
        DateTime DateOfBirth { get; set; }
        SocialMedia SocialMedia { get; set; }
    }
}