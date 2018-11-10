using System.Threading.Tasks;

namespace Leave.Infrastructure.Commands.Base
{
    public interface ICommandHandler<T> where T : ICommand
    {
         Task HandleAsync(T command);
    }
}
