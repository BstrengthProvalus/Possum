using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PossumProject.Startup))]
namespace PossumProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
