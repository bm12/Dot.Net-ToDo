using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo.Models
{
    public class TodoTask
    {
        public int TodoTaskId { get; set; }
        public string Title { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public TodoStatus Status { get; set; } = TodoStatus.Active;

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
