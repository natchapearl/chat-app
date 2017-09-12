using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SimpleSignalRChatApp.Startup))]

namespace SimpleSignalRChatApp
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //Mapping hub to the app builder
            app.MapSignalR();
        }
    }
}
