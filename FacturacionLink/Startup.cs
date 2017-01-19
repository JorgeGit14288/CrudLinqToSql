using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FacturacionLink.Startup))]
namespace FacturacionLink
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
