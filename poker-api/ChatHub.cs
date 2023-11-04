using Microsoft.AspNetCore.SignalR;

namespace poker_api;

    public class ChatHub: Hub
    { 
        public override async Task OnConnectedAsync()
        {
            Console.WriteLine("Connected");
            await Clients.All.SendAsync("Receive Message", $"{Context.ConnectionId} connected");
        }
    }

