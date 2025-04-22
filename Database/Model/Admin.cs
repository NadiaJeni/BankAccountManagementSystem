using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Model
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Required, MaxLength(255), EmailAddress]
        public string Email { get; set; }

        [Required]
        public string PasswordHash { get; set; }  // Encrypted password

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
