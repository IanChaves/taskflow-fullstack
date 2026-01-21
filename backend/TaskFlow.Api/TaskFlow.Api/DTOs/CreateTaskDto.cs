using System.ComponentModel.DataAnnotations;

namespace TaskFlow.Api.DTOs
{
    public class CreateTaskDto
    {
        [Required]
        [MinLength(3)]
        public string Title { get; set; } = string.Empty;
    }
}