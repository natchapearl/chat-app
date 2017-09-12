using Microsoft.AspNet.SignalR;

namespace SimpleSignalRChatApp
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            //sendMessage method is being called to update all clients.
            Clients.All.sendMessage(name, message);
        }
    }
}