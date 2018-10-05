using System;

namespace CV.Contracts.Profile
{
    public class Profile : IProfile
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ContactDetails ContactDetails { get; set; }
        public DateTime DateOfBirth { get; set; }
        public SocialMedia SocialMedia { get; set; }
    }
}