using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lab4DoTanPhat.Startup))]
namespace lab4DoTanPhat
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
