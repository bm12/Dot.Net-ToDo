﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string CreatedAt { get; set; }

        public List<TodoTask> Todos { get; } = new List<TodoTask>();
    }
}
