﻿using Application.CQRS.Communication.Chat;
using Application.Responses.Peticiones;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using Shared.Constants;

namespace IGift2.Hubs
{
    [Authorize]
    public class SignalRHub : Hub
    {
        public async Task OnConnectAsync(string userId)
        {
            await Clients.All.SendAsync(AppConstants.SignalR.ConnectUserAsync, userId);
        }

        public async Task OnDisconnectAsync(string userId)
        {
            await Clients.All.SendAsync(AppConstants.SignalR.DisconnectUserAsync, userId);
        }

        public async Task ChatNotificationAsync(string message, string receiverUserId, string senderUserId)
        {
            await Clients.User(receiverUserId).SendAsync(AppConstants.SignalR.ReceiveChatNotificationAsync, message, receiverUserId, senderUserId);
        }

        public async Task SendShopCartNotificationAsync(PeticionesResponse p, string UserId)
        {
            await Clients.User(UserId).SendAsync(AppConstants.SignalR.ReceiveShopCartNotificationAsync, p);
        }

        public async Task RegenerateTokensAsync()
        {
            await Clients.All.SendAsync(AppConstants.SignalR.ReceiveRegenerateTokensAsync);
        }

        public async Task SendMessageAsync(SaveChatMessage chat, string CurrentUserId, string userName)
        {
            //await Clients.All.SendAsync("ReceiveMessage", userName);

            await Clients.User(chat.ToUserId).SendAsync(AppConstants.SignalR.ReceiveMessageAsync, chat, userName);
            await Clients.User(chat.FromUserId).SendAsync(AppConstants.SignalR.ReceiveMessageAsync, chat, userName);
        }

        public async Task SendChatNotificationAsync(SaveChatMessage chat, string receiverUserId)
        {
            await Clients.User(chat.ToUserId).SendAsync(AppConstants.SignalR.ReceiveChatNotificationAsync, chat, receiverUserId);
        }
    }
}
