using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IrrigationAdvisor.Startup))]
namespace IrrigationAdvisor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
