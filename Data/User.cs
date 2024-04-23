﻿using System.ComponentModel.DataAnnotations;

namespace TaskManager.Data
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public ICollection<Task> Tasks { get; set; } // Navigation property
    }
}
