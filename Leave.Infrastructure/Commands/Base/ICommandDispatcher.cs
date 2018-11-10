using System.Threading.Tasks;

namespace Leave.Infrastructure.Commands.Base
{
    public interface ICommandDispatcher
    {
        Task DispatchAsync<T>(T command) where T : ICommand;
    }
}
