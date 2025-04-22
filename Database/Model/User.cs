using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Model
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Required, MaxLength(255), EmailAddress]
        public string Email { get; set; }

        [Required]
        public string PasswordHash { get; set; }  // Store encrypted passwords

        [Required, MaxLength(50)]
        public string Role { get; set; }  // Customer, Admin, Staff

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Navigation property
        public virtual ICollection<Account> Accounts { get; set; }
    }

}
