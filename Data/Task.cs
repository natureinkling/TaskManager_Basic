using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManager.Data
{
    public class Task
    {
        [Key]
        public int TaskID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }

        [ForeignKey("User")] // Specify the navigation property name
        public int UserID { get; set; } // Foreign key

        [NotMapped] // This property is not mapped to a database column
        public User User { get; set; } // Navigation property
        public bool IsCompleted { get; set; } // Status: true if completed, false otherwise
    }
}
