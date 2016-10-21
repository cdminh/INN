using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Inn_Demo.Startup))]
namespace Inn_Demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
