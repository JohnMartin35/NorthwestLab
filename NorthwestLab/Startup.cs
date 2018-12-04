using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NorthwestLab.Startup))]
namespace NorthwestLab
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
