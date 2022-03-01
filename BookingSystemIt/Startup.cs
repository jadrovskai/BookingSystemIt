using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookingSystemIt.Startup))]
namespace BookingSystemIt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
