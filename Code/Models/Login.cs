using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Commerce.Models
{
    [Table("Login")]
    public partial class Login
    {
        public Login()
        {
            Customers = new HashSet<Customer>();
            LoginHistories = new HashSet<LoginHistory>();
        }

        [Key]
        [Column("User_ID")]
        [StringLength(15)]
        public string UserId { get; set; }
        [Column("User_name")]
        [StringLength(50)]
        public string UserName { get; set; }
        [Column("User_password")]
        [StringLength(50)]
        public string UserPassword { get; set; }

        [InverseProperty(nameof(Customer.User))]
        public virtual ICollection<Customer> Customers { get; set; }
        [InverseProperty(nameof(LoginHistory.User))]
        public virtual ICollection<LoginHistory> LoginHistories { get; set; }
    }
}
