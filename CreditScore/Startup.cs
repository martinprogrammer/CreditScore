using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CreditScore.Startup))]
namespace CreditScore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
