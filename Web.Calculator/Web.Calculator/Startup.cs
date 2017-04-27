using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web.Calculator.Startup))]
namespace Web.Calculator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
