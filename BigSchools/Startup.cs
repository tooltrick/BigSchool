using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BigSchools.Startup))]
namespace BigSchools
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
