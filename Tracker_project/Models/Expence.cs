using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public required string Category { get; set; }

        [Required]
        public decimal Price { get; set; }

        public string? Note { get; set; }

        public DateTime Date { get; set; } = DateTime.UtcNow;
    }
}