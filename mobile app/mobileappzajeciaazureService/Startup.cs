using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(mobileappzajeciaazureService.Startup))]

namespace mobileappzajeciaazureService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}