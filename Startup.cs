using Owin;
using Microsoft.Owin;
[assembly: OwinStartup(typeof(SignalRChatMVC.Startup))]

namespace SignalRChatMVC
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}