using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Tutorial_Vidly.Startup))]
namespace MVC_Tutorial_Vidly
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
