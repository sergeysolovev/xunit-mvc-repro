using Microsoft.AspNetCore.Http;
using System;

namespace FunctionalTests.Internal
{
    internal class CustomHttpContextAccessor : IHttpContextAccessor
    {
        private HttpContext context;

        public CustomHttpContextAccessor()
        {
        }

        public HttpContext HttpContext
        {
            get
            {
                if (context == null)
                {
                    context = new DefaultHttpContext();
                }

                return context;
            }
            set
            {
                context = value;
            }
        }
    }
}
