using CV.Contracts.Profile;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

namespace CV.Contracts.UnitTests
{
    [TestClass]
    public class CountryUnitTests
    {
        [TestMethod]
        public void Given_CountryCode_ShouldReturn_ValidFlagApiUrl()
        {
            var country = new Country("CH", "Switzerland");
            country.ApiUrl.ShouldBe("https://www.countryflags.io/CH/");
        }
    }
}
