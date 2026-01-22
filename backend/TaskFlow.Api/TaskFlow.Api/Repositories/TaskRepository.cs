using Microsoft.EntityFrameworkCore;
using TaskFlow.Api.Data;
using TaskFlow.Api.Exceptions;
using TaskFlow.Api.Models;

namespace TaskFlow.Api.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly TaskFlowDbContext _context;

        public TaskRepository(TaskFlowDbContext context)
        {
            _context = context;
        }

        public IEnumerable<TaskItem> GetAll()
            => _context.Tasks.AsNoTracking().ToList();

        public TaskItem Add(string title)
        {
            if (_context.Tasks.Any(t => t.Title == title))
                throw new DuplicateTaskException(title);

            var task = new TaskItem { Title = title };

            _context.Tasks.Add(task);
            _context.SaveChanges();

            return task;
        }

        public void Toggle(Guid id)
        {
            var task = _context.Tasks.Find(id);
            if (task == null) return;

            task.IsCompleted = !task.IsCompleted;
            _context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var task = _context.Tasks.Find(id);
            if (task == null) return;

            _context.Tasks.Remove(task);
            _context.SaveChanges();
        }
    }

}

