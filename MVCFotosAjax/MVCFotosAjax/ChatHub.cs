using System;
using System.Web;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;

namespace MVCFotosAjax
{
    public class ChatHub:Hub
    {
        public Task Join(int photoId)
        {
            return Groups.Add(Context.ConnectionId, "Photo"+ photoId);
        }

        public Task Send(string userName, int photoId, string message)
        {
            string groupname = "Photo" + photoId;
            return Clients.Group(groupname).addMessage(userName, message);
        }


        
    }
}