using NUnit.Framework;

/// <summary>
/// Mocks and tests for the Controller interfaces 
/// are listed in this class. It is important we 
/// keep this class independent of the application 
/// CICD. So anything implemented should not be 
/// connecting to the external services.
/// </summary>
namespace UrlShortener2.UnitTests.ControllerTests
{
    public class UrlControllerTests
    {
        [TestFixture]
        public void getShortUrlTest()
        {
            // Test the shortened URL 
        }

        [TestFixture]
        public void assertUpdateUrlTest()
        {
            // Assert that the updated URL works as expected
            // Shorten a URL, then update, and retrieve + assert
        }

    }
}
