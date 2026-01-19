using TaskFlow.Api.Models;

namespace TaskFlow.Api.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private static readonly List<TaskItem> _tasks = [];

        public IEnumerable<TaskItem> GetAll()
            => _tasks;

        public TaskItem Add(string title)
        {
            var task = new TaskItem { Title = title };
            _tasks.Add(task);
            return task;
        }

        public void Toggle(Guid id)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == id);
            if (task != null)
                task.IsCompleted = !task.IsCompleted;
        }

        public void Delete(Guid id)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == id);
            if (task != null)
                _tasks.Remove(task);
        }
    }

}

