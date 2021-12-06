using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Commerce.Models
{
    [Table("LoginHistory")]
    public partial class LoginHistory
    {
        [Key]
        [Column("LHID")]
        public int Lhid { get; set; }
        [Column("UserID")]
        [StringLength(15)]
        public string UserId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LoginTime { get; set; }

        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(Login.LoginHistories))]
        public virtual Login User { get; set; }
    }
}
