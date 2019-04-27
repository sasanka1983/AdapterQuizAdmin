using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdapterQuizAdmin.Startup))]
namespace AdapterQuizAdmin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
