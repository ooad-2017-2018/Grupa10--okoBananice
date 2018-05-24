using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PostaMVC.Startup))]
namespace PostaMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
