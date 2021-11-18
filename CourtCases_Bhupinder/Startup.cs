using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CourtCases_Bhupinder.Startup))]
namespace CourtCases_Bhupinder
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
