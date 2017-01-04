using Microsoft.Owin;
using Owin;
using Package1;

[assembly: OwinStartup(typeof(Startup))]

namespace Package1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
        }
    }
}
