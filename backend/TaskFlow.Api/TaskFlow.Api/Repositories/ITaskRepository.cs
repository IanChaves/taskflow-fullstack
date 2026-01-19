using global::TaskFlow.Api.Models;

namespace TaskFlow.Api.Repositories
{
    public interface ITaskRepository
    {
        IEnumerable<TaskItem> GetAll();
        TaskItem Add(string title);
        void Toggle(Guid id);
        void Delete(Guid id);
    }

}
