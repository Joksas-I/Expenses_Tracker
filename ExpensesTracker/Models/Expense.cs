using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExpensesTracker.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Purchased item")]
        [Required(ErrorMessage ="No item added!")]
        public string PurchasedItem { get; set; }
        [DisplayName("Amount spent")]
        [Required(ErrorMessage ="No amount added!")]
        [Range(0.01, double.MaxValue, ErrorMessage ="Incorrect amount.")]
        public int AmountSpent { get; set; }
    }
}
