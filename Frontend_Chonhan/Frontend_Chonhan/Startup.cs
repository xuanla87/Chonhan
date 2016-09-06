using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Frontend_Chonhan.Startup))]
namespace Frontend_Chonhan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
