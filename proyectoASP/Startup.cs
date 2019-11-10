using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(proyectoASP.Startup))]
namespace proyectoASP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
