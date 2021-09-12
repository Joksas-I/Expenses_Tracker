using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExpensesTracker.Models
{
    public class Balance
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Balance")]
        public int MoneyBalance { get; set; } = 0;
    }
}
