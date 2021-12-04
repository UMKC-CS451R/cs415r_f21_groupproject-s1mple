using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Commerce.Models
{
    [Table("Customer")]
    [Index(nameof(UserId), nameof(AccountNumber), nameof(Ssn), Name = "u_customer", IsUnique = true)]
    public partial class Customer
    {
        [Key]
        [Column("Account_Number")]
        [StringLength(15)]
        public string AccountNumber { get; set; }
        [Key]
        [Column("User_id")]
        [StringLength(15)]
        public string UserId { get; set; }
        [Column("First_Name")]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Column("Last_Name")]
        [StringLength(50)]
        public string LastName { get; set; }
        [Column("Date_of_birth", TypeName = "date")]
        public DateTime? DateOfBirth { get; set; }
        [StringLength(1)]
        public string Gender { get; set; }
        [StringLength(255)]
        public string Address { get; set; }
        [StringLength(70)]
        public string Email { get; set; }
        [Column("Phone_number")]
        [StringLength(10)]
        public string PhoneNumber { get; set; }
        [Column("SSN")]
        [StringLength(9)]
        public string Ssn { get; set; }

        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(Login.Customers))]
        public virtual Login User { get; set; }
    }
}
