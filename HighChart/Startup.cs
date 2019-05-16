using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HighChart.Startup))]
namespace HighChart
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
