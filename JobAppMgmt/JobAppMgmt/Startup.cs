using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JobAppMgmt.Startup))]
namespace JobAppMgmt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
