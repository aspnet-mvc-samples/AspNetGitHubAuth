using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspNetGitHubAuth.Startup))]
namespace AspNetGitHubAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
