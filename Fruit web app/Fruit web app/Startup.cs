using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fruit_web_app.Startup))]
namespace Fruit_web_app
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
