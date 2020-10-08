using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bagmati.Startup))]
namespace Bagmati
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
