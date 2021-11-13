using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HackathonMockup.Startup))]
namespace HackathonMockup
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
