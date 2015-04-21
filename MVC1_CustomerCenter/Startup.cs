using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC1_CustomerCenter.Startup))]
namespace MVC1_CustomerCenter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
