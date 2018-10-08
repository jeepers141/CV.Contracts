using System;
using System.Collections.Generic;

namespace CV.Contracts.Profile
{
    public interface IProfile : IContact
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        DateTime DateOfBirth { get; set; }
        string CountryOfBirth { get; set; }
        string CountryOfResidence { get; set; }
        IEnumerable<Language> Languages { get; set; }
    }
}
