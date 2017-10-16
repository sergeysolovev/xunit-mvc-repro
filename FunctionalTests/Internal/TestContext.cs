using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using System.Net.Http;

namespace FunctionalTests.Internal
{
    internal class TestContext : IDisposable
    {
        private readonly TestServer server;
        private readonly HttpClient client;

        public TestContext()
        {
            var builder = new WebHostBuilder()
               .UseContentRoot(WebSite.GetContentRoot())
               .ConfigureServices(services => {
                   services.AddMvc();
                   services.AddSingleton<IHttpContextAccessor>(
                       new CustomHttpContextAccessor()
                   );
               })
               .Configure(app => app.UseMvcWithDefaultRoute());

            server = new TestServer(builder);
            client = server.CreateClient();
        }

        public HttpClient Client => client;

        public IServiceProvider Services => server.Host.Services;

        public void Dispose()
        {
            server?.Dispose();
            client?.Dispose();
        }
    }
}
