using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InOutStatus.Startup))]
namespace InOutStatus
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
