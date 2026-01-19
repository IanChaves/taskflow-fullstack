using Microsoft.AspNetCore.Mvc;
using TaskFlow.Api.DTOs;
using TaskFlow.Api.Repositories;

namespace TaskFlow.Api.Controllers
{
    [ApiController]
    [Route("api/tasks")]
    public class TaskController : ControllerBase
    {
        private readonly ITaskRepository _repository;

        public TaskController(ITaskRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetAll()
            => Ok(_repository.GetAll());

        [HttpPost]
        public IActionResult Create(CreateTaskDto dto)
            => Ok(_repository.Add(dto.Title));

        [HttpPut("{id}/toggle")]
        public IActionResult Toggle(Guid id)
        {
            _repository.Toggle(id);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            _repository.Delete(id);
            return NoContent();
        }
    }
}

