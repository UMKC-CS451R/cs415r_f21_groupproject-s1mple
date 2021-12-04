using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Commerece.Models
{
    [Table("Trigger_")]
    public partial class Trigger
    {
        [Key]
        [Column("Trigger_ID")]
        [StringLength(15)]
        public string TriggerId { get; set; }
        [Column("Trigger_description")]
        [StringLength(50)]
        public string TriggerDescription { get; set; }
    }
}
