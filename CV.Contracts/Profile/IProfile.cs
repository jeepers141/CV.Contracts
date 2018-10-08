using System;
using System.Collections.Generic;

namespace CV.Contracts.Profile
{
    public interface IProfile : IContact
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        DateTime DateOfBirth { get; set; }
        IEnumerable<Language> Languages { get; set; }
        Country CountryOfBirth { get; set; }
        Country CountryOfResidence { get; set; }

    }
}
