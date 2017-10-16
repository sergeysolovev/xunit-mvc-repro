using System.IO;

namespace FunctionalTests.Internal
{
    internal static class WebSite
    {
        public static string GetContentRoot()
        {
            var currentDirectory = Directory.GetCurrentDirectory();
            var webSiteRelativePath = @"..\..\..\..\BasicWebSite\";

            return Path.Combine(currentDirectory, webSiteRelativePath);
        }
    }
}
