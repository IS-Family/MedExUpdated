using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MedExUpdated.Startup))]
namespace MedExUpdated
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
