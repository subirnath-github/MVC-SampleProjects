using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_SampleApp_1.Startup))]
namespace MVC_SampleApp_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
