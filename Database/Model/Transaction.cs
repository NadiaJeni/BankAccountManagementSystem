using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Model
{
    public class Transaction
    {
        [Key]
        public int TransactionID { get; set; }

        [Required]
        public int AccountID { get; set; }  // Foreign Key

        [Required, MaxLength(50)]
        public string TransactionType { get; set; }  // Deposit, Withdrawal, Transfer

        [Required, Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }

        public DateTime TransactionDate { get; set; } = DateTime.Now;

        // Navigation property
        [ForeignKey("AccountID")]
        public virtual Account Account { get; set; }
    }
}
