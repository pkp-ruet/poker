using poker_api;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSignalR();
var app = builder.Build();
app.MapHub<ChatHub>("/chat-hub");


app.Run();
