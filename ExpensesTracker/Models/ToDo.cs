using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExpensesTracker.Models
{
    public class ToDo
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Item name")]
        public string ToDoItem { get; set; }

        [DisplayName("Done")]
        public bool IsDone { get; set; } = true;
    }
}
