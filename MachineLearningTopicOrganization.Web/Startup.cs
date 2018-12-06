using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MachineLearningTopicOrganization.Web.Startup))]
namespace MachineLearningTopicOrganization.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
