using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PaginaContacto.Startup))]
namespace PaginaContacto
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
