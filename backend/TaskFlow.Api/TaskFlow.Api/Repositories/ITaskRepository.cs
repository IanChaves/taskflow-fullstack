using global::TaskFlow.Api.Models;
using TaskFlow.Api.DTOs;

namespace TaskFlow.Api.Repositories
{
    public interface ITaskRepository
    {
        IEnumerable<TaskDto> GetAll();
        TaskItem Add(string title);
        void Toggle(Guid id);
        void Delete(Guid id);
    }

}
