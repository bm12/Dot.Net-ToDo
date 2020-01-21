using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo.Models
{
    public class Task
    {
        public string Title { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public TaskStatus Status { get; set; } = TaskStatus.Active;
    }
}
