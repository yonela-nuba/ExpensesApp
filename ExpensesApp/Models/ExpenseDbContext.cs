﻿

using Microsoft.EntityFrameworkCore;

namespace ExpensesApp.Models
{
    public class ExpenseDbContext : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }

        public ExpenseDbContext(DbContextOptions<ExpenseDbContext> options) 
            : base(options) 
        {

        }
    }
}
