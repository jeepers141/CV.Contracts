using System;
using System.Collections.Generic;

namespace CV.Contracts.Profile
{
    public class Profile : IProfile
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ContactDetails ContactDetails { get; set; }
        public DateTime DateOfBirth { get; set; }
        public SocialMedia SocialMedia { get; set; }
        public string CountryOfBirth { get; set; }
        public string CountryOfResidence { get; set; }
        public IEnumerable<Language> Languages { get; set; }
    }
}