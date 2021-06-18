using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(EmailAutomation.Startup))]

namespace EmailAutomation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}