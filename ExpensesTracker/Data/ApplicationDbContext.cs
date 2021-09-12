using ExpensesTracker.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpensesTracker.Data
{
    public class ApplicationDdContext :DbContext
    {
        public ApplicationDdContext(DbContextOptions<ApplicationDdContext> options) : base(options)
        {

        }

        public DbSet<Item> Items{ get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<ToDo> ToDoItems { get; set; }
        public DbSet<Balance> Balances { get; set; }
    }
}
