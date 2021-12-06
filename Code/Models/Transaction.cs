using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Commerce.Models
{
    [Table("Transaction_")]
    public partial class Transaction
    {
        [Key]
        [Column("Transaction_ID")]
        [StringLength(15)]
        public string TransactionId { get; set; }
        [Column("Account_No")]
        [StringLength(15)]
        public string AccountNo { get; set; }
        [Column("Transaction_type")]
        [StringLength(10)]
        public string TransactionType { get; set; }
        public double? Amount { get; set; }
        public double? Balance { get; set; }
        [Column("Processing_Date", TypeName = "datetime")]
        public DateTime? ProcessingDate { get; set; }
        [StringLength(100)]
        public string Description { get; set; }
        [StringLength(60)]
        public string Location { get; set; }
    }
}
