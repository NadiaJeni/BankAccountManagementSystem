using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Model
{
    public class Account
    {
        [Key]
        public int AccountID { get; set; }

        [Required]
        public int UserID { get; set; }  // Foreign Key

        [Required, MaxLength(50)]
        public string AccountType { get; set; }  // Savings, Checking, Loan

        [Required, Column(TypeName = "decimal(18,2)")]
        public decimal Balance { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Navigation property
        [ForeignKey("UserID")]
        public virtual User User { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
