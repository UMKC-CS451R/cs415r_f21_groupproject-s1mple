using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Commerce.Models
{
    [Table("NotficationRule")]
    public partial class NotficationRule
    {
        [Key]
        [Column("NRid")]
        public int Nrid { get; set; }
        [Column("Account_Number")]
        [StringLength(15)]
        public string AccountNumber { get; set; }
        [StringLength(50)]
        public string Location { get; set; }
        [Column("startTime", TypeName = "datetime")]
        public DateTime? StartTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndTime { get; set; }
        public bool? Locationstatus { get; set; }
        public bool? TimeFrame { get; set; }
    }
}
