using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProyectoGru.Startup))]
namespace ProyectoGru
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
