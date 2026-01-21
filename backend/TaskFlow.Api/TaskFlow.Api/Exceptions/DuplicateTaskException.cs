namespace TaskFlow.Api.Exceptions
{
    public class DuplicateTaskException : Exception
    {
        public DuplicateTaskException(string title)
            : base($"Task with title '{title}' already exists.")
        {
        }
    }
}

