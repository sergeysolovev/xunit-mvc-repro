using System.Net;
using System.Threading.Tasks;
using FunctionalTests.Internal;
using Xunit;

namespace FunctionalTests
{
    public class WhenRequestingRazorView
    {
        [Fact]
        public async Task ShouldRespondWithValidContent()
        {
            using (var context = new TestContext())
            {
                var expectedContent = $"<div></div>";

                var response = await context.Client.GetAsync("/Test/Index");
                var responseContent = await response.Content.ReadAsStringAsync();

                Assert.Equal(HttpStatusCode.OK, response.StatusCode);
                Assert.Equal(expectedContent, responseContent);
            }
        }
    }
}
