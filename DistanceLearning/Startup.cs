using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DistanceLearning.Startup))]
namespace DistanceLearning
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
