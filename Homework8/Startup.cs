using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Homework8.Startup))]
namespace Homework8
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
