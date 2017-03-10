using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NIIT.BookStore.Web.Startup))]
namespace NIIT.BookStore.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
