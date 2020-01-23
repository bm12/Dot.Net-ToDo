using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ToDo.Models;

namespace ToDo.Controllers
{
    [ApiController]
    [Route("task")]
    public class TaskController : ControllerBase
    {
        private readonly ILogger<TaskController> _logger;
        private readonly List<TodoTask> _todos = new List<TodoTask>
        {
            new TodoTask { Title = "learn C#" },
            new TodoTask { Title = "learn dot.net" },
            new TodoTask { Title = "learn db" },
        };

        public TaskController(ILogger<TaskController> logger)
        {
            _logger = logger;
        }

        [HttpGet("get")]
        public IActionResult Get()
        {
            return Ok(_todos);
        }
        [HttpGet("get/{id}")]
        public IActionResult Get(int id)
        {
            var todo = _todos.ElementAtOrDefault(id);
            if (todo == null)
                return NotFound();

            return Ok(todo);
        }
    }
}
