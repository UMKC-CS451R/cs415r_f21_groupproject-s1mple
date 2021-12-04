using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Commerce.Models
{
    [Table("Account")]
    public partial class Account
    {
        [Key]
        [Column("Account_Num")]
        [StringLength(15)]
        public string AccountNum { get; set; }
        [Column("Account_type")]
        [StringLength(55)]
        public string AccountType { get; set; }
        [Column("Creation_date", TypeName = "datetime")]
        public DateTime? CreationDate { get; set; }
    }
}
