using System;
using System.Collections.Generic;
using System.Linq;
using Threading = System.Threading;
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
        private readonly List<Task> _todos = new List<Task>
        {
            new Task { Title = "learn C#" },
            new Task { Title = "learn dot.net" },
            new Task { Title = "learn db" },
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
