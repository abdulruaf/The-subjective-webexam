using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(The_subjective_webexam.Startup))]
namespace The_subjective_webexam
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
