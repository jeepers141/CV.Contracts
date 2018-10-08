using CV.Contracts.Profile;
using Shouldly;
using Xunit;

namespace Contract.Unittests
{
    public class UnitTest1
    {
        [Fact]
        public void Given_CountryCode_ShouldReturn_ValidFlagApiUrl()
        {
            var country = new Country("CH", "Switzerland");
            country.ApiUrl.ShouldBe("https://www.countryflags.io/CH/");
        }
    }
}
