using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hoteles_del_Recuerdo.Startup))]
namespace Hoteles_del_Recuerdo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
