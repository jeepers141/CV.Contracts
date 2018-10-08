using CV.Contracts.Profile;
using Shouldly;
using Xunit;

namespace CV.Contracts.UnitTests
{
    public class CountryUnitTests
    {
        [Fact]
        public void Given_CountryCode_ShouldReturn_ValidFlagApiUrl()
        {
            var country = new Country("CH", "Switzerland");
            country.ApiUrl.ShouldBe("https://www.countryflags.io/CH/");
        }
    }
}
