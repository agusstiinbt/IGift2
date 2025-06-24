namespace IGift.Application.MongoDb.Interfaces.Models
{
    public interface IChatService
    {
        /// <summary>
        /// Guarda un mensaje a un chat en particular
        /// </summary>
        /// <param name="saveChatMessage"></param>
        /// <returns></returns>
        Task<IResult> SaveMessage(SaveChatMessage saveChatMessage);

        /// <summary>
        /// Trae desde la bbdd el chat completo y pone como visto el ultimo mensaje
        /// </summary>
        /// <param name="ToUserId">Este es el id del usuario con el que estamos chateando. Esto se usara para traer el chat correspondiente con este IdUser</param>
        /// <returns></returns>
        //Task<IResult<IEnumerable<ChatHistoryRequest>>> GetChatMessages(SearchChatById info);

        /// <summary>
        /// Este metodo carga los bubbles(chats historicos) del costado del chatroom. Solamente trae el ultimo mensaje para ser visto desde fuera.
        /// </summary>
        /// <returns></returns>
        Task<IResult<IEnumerable<ChatUserResponse>>> LoadChatUsers(string CurrentUserId);
    }
    public interface IChatService2
    {
        /// <summary>
        /// Este metodo solo debe recibir un ChatHistory con los ids de los usuarios
        /// </summary>
        /// <param name="chat">Solo debe contener los Ids</param>
        /// <returns></returns>
        Task<List<ChatHistory>> FindAllAsync(ChatHistory chat);
        Task CreateAsync();
    }
}
