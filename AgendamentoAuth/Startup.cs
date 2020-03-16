using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AgendamentoAuth.Startup))]
namespace AgendamentoAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
