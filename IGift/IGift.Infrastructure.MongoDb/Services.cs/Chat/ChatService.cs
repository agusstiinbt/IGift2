﻿using IGift.Infrastructure.MongoDb.Data;
using Microsoft.Extensions.DependencyInjection;

namespace IGift.Infrastructure.MongoDb.Services.cs.Chat
{
    public class ChatService : IChatService
    {
        #region Para cuando querramos encriptar el codigo

        //private readonly byte[] _key;
        //private readonly string _path;

        //public ChatService(string key, string path)
        //{
        //    _key = Encoding.UTF8.GetBytes(key);
        //    _path = path;
        //}
        //public async Task<IResult> SaveMessage(ChatHistory chat)
        //{

        //    //var iv = GenerateIV();
        //    //var encryptedUserId = Encrypt(chat.FromUserId, _key, iv);
        //    //var filePath = Path.Combine(_path, $"{Convert.ToBase64String(encryptedUserId)}.txt");

        //    //var serializedMessage = JsonConvert.SerializeObject(chat);
        //    //var encryptedMessage = Encrypt(serializedMessage, _key, iv);

        //    //using (var stream = new FileStream(filePath, FileMode.Append))
        //    //{
        //    //    // Write IV to the file
        //    //    stream.Write(iv, 0, iv.Length);

        //    //    // Write encrypted message to the file
        //    //    stream.Write(encryptedMessage, 0, encryptedMessage.Length);
        //    //}
        //    return await Result.SuccessAsync();
        //}

        //private byte[] GenerateIV()
        //{
        //    using (Aes aes = Aes.Create())
        //    {
        //        aes.GenerateIV();
        //        return aes.IV;
        //    }
        //}
        //private byte[] Encrypt(string simpletext, byte[] key, byte[] iv)
        //{
        //    byte[] cipheredtext;
        //    using (Aes aes = Aes.Create())
        //    {
        //        ICryptoTransform encryptor = aes.CreateEncryptor(key, iv);
        //        using (MemoryStream memoryStream = new MemoryStream())
        //        {
        //            using (CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
        //            {
        //                using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
        //                {
        //                    streamWriter.Write(simpletext);
        //                }

        //                cipheredtext = memoryStream.ToArray();
        //            }
        //        }
        //    }
        //    return cipheredtext;
        //}
        //private string Decrypt(byte[] cipheredtext, byte[] key, byte[] iv)
        //{
        //    string simpletext = String.Empty;
        //    using (Aes aes = Aes.Create())
        //    {
        //        ICryptoTransform decryptor = aes.CreateDecryptor(key, iv);
        //        using (MemoryStream memoryStream = new MemoryStream(cipheredtext))
        //        {
        //            using (CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
        //            {
        //                using (StreamReader streamReader = new StreamReader(cryptoStream))
        //                {
        //                    simpletext = streamReader.ReadToEnd();
        //                }
        //            }
        //        }
        //    }
        //    return simpletext;
        //}

        //private async Task<IResult> SaveChatToFile(ChatHistory chat)
        //{
        //    return null;
        //}

        #endregion

        private readonly DbContext _context;
        //private readonly IProfilePicture _profileService;//Para mas informacion de por que no usamos este servicio leer el metodo LoadChatUsers
        private readonly IServiceScopeFactory _scopeFactory;

        public ChatService(DbContext context, IServiceScopeFactory scopeFactory)
        {
            _context = context;
            _scopeFactory = scopeFactory;
        }

        public async Task<IResult<IEnumerable<ChatHistoryResponse>>> GetChatMessages(SearchChatById info)
        {
            //List<ChatHistory<IGiftUser>> chatHistories = null;

            //if (info.IsFirstTime)
            //{
            //    chatHistories = await _context.ChatHistories
            //                    .Include(x => x.FromUser)
            //                    .Include(x => x.ToUser)
            //                    .Where(x =>
            //                        (x.ToUserId == info.ToUserId && x.FromUserId == info.FromUserId) ||
            //                        (x.ToUserId == info.FromUserId && x.FromUserId == info.ToUserId))
            //                    .OrderByDescending(x => x.CreatedDate)
            //                    .Take(20)
            //                    //.AsNoTracking()
            //                    .ToListAsync(); // Traemos todos los mensajes en una sola consulta
            //}
            //else
            //{
            //    chatHistories = await _context.ChatHistories
            //                 .Include(x => x.FromUser)
            //                 .Include(x => x.ToUser)
            //                 .Where(
            //                    x => (
            //                (x.ToUserId == info.ToUserId && x.FromUserId == info.FromUserId) || (x.ToUserId == info.FromUserId && x.FromUserId == info.ToUserId))
            //                && (x.CreatedDate < info.LastMessageDate)
            //                    )
            //                 .OrderByDescending(x => x.CreatedDate)
            //                 .Take(10)
            //                 //.AsNoTracking()
            //                 .ToListAsync(); // Traemos todos los mensajes en una sola consulta
            //}
            //if (!chatHistories.Any())
            //    return await Result<IEnumerable<ChatHistoryResponse>>.FailAsync("No existen chats con el usuario");

            //// Marcar como leído solo el primer mensaje más antiguo
            //var firstMessage = chatHistories.OrderByDescending(x => x.CreatedDate).FirstOrDefault();
            //if (firstMessage != null && !firstMessage.Seen && firstMessage.ToUserId == info.FromUserId)
            //{
            //    firstMessage.Seen = true;
            //    await _context.SaveChangesAsync();
            //}

            ////Importante:!!
            ////Usamos un select de esta manera (en ejecucion en memoria) y no una expression (ejecucion en sql) porque en este metodo evitamos el uso de AsNoTracking al tener que modificar el seen del ultimo mensaje.
            ////La proyección (Select) se hace en memoria para evitar problemas de traducción en EF Core

            //var result = chatHistories.Select(mensaje =>
            //{
            //    bool soyYo = mensaje.FromUserId == info.FromUserId;
            //    var otroUsuario = soyYo ? mensaje.ToUser : mensaje.FromUser;

            //    return new ChatHistoryResponse
            //    {
            //        FromUserId = mensaje.FromUserId,
            //        ToUserId = mensaje.ToUserId,
            //        Message = mensaje.Message,
            //        Seen = mensaje.Seen,
            //        Date = mensaje.CreatedDate,
            //        Send = true,
            //        Received = mensaje.Received,
            //    };
            //});

            //return await Result<IEnumerable<ChatHistoryResponse>>.SuccessAsync(result);
            return null;

        }

        public async Task<IResult<IEnumerable<ChatUserResponse>>> LoadChatUsers(string CurrentUserId)
        {
            //var chatHistories = await _context.ChatHistories
            //    .Include(x => x.FromUser)
            //    .Include(x => x.ToUser)
            //    .Where(x => x.FromUserId == CurrentUserId || x.ToUserId == CurrentUserId)
            //    .GroupBy(x => new { x.FromUserId, x.ToUserId })
            //    .Select(g => g.OrderByDescending(x => x.CreatedDate).First())
            //    .AsNoTracking()
            //    .ToListAsync();

            //if (!chatHistories.Any())
            //    return await Result<IEnumerable<ChatUserResponse>>.FailAsync();

            //var groupedChats = chatHistories
            //    .GroupBy(x => new
            //    {
            //        User1 = string.Compare(x.FromUserId, x.ToUserId) < 0 ? x.FromUserId : x.ToUserId,
            //        User2 = string.Compare(x.FromUserId, x.ToUserId) > 0 ? x.FromUserId : x.ToUserId
            //    })
            //    .Select(g => g.OrderByDescending(x => x.CreatedDate).First())
            //    .ToList();

            //var tasks = groupedChats.Select(async mensaje =>
            //{
            //    using var scope = _scopeFactory.CreateScope();
            //    //🧠 ¿Por qué no usar _profileService directamente?
            //    //Ese servicio fue inyectado junto con el ChatService, lo que significa que usa el mismo DbContext que se inyectó a ChatService. Si usás ese mismo _profileService dentro de múltiples tareas en paralelo(como con Task.WhenAll), vas a volver a caer en el mismo problema de concurrencia, porque estarías compartiendo indirectamente el mismo DbContext.Porque eso crea un nuevo IProfilePicture, que a su vez tiene un nuevo DbContext detrás. Eso permite que cada tarea trabaje de forma aislada y segura en paralelo, sin pisarse con otras.
            //    var profileService = scope.ServiceProvider.GetRequiredService<IProfilePicture>();
            //    bool soyYo = mensaje.FromUserId == CurrentUserId;
            //    var otroUsuario = soyYo ? mensaje.ToUser : mensaje.FromUser;
            //    var foto = await profileService.GetByUserIdAsync2(otroUsuario.Id);
            //    return new ChatUserResponse
            //    {
            //        LastMessage = mensaje.Message,
            //        Seen = mensaje.Seen,
            //        IsLastMessageFromMe = soyYo,
            //        UserName = otroUsuario.UserName,
            //        Data = foto?.Data,
            //        UserId = otroUsuario.Id,
            //        Date = mensaje.CreatedDate
            //    };
            //});
            //var result = await Task.WhenAll(tasks);
            // return await Result<IEnumerable<ChatUserResponse>>.SuccessAsync(result);
            return null;
        }

        public async Task<IResult> SaveMessage(SaveChatMessage chat)
        {
            //var userResponse = //TODO esto deberia ser el cliente http //await _userService.GetByIdAsync(chat.ToUserId);

            //if (!userResponse.Succeeded)
            //    return await Result.FailAsync("El usuario no existe");

            //await _context.ChatHistories.AddAsync(new ChatHistory<IGiftUser>
            //{
            //    FromUserId = chat.FromUserId,
            //    ToUserId = chat.ToUserId,
            //    Message = chat.Message,
            //    CreatedDate = DateTime.Now,
            //    Seen = false,
            //    Send = true,
            //    Received = true
            //});

            //await _context.SaveChangesAsync();

            return await Result.SuccessAsync();
        }
    }
}
