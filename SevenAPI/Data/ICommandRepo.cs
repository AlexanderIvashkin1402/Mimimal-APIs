using SevenApi.Models;

namespace SevenApi.Data
{
    public interface ICommandRepo
    {
        Task SaveChanges();

        Task<IEnumerable<Command>> GetAllCommands();
        Task<Command?> GetCommandById(int id);
        Task CreateCommand(Command cmd);
    
        void DeleteCommand(Command cmd);
    }
}