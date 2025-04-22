using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Model
{
    public class Loan
    {
        [Key]
        public int LoanID { get; set; }

        [Required]
        public int UserID { get; set; }  // Foreign Key

        [Required, Column(TypeName = "decimal(18,2)")]
        public decimal LoanAmount { get; set; }

        [Required, MaxLength(50)]
        public string Status { get; set; }  // Pending, Approved, Rejected

        public DateTime AppliedDate { get; set; } = DateTime.Now;

        // Navigation property
        [ForeignKey("UserID")]
        public virtual User User { get; set; }
    }

}
