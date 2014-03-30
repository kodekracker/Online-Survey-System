using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Online_Survey_System.Startup))]
namespace Online_Survey_System
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
