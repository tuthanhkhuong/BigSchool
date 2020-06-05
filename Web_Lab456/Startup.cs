using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web_Lab456.Startup))]
namespace Web_Lab456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
