using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestRepo3.Startup))]
namespace TestRepo3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
