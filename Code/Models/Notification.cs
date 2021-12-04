using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Commerece.Models
{
    [Table("Notification")]
    public partial class Notification
    {
        [Key]
        [Column("Notification_ID")]
        [StringLength(15)]
        public string NotificationId { get; set; }
        [Column("Acc_number")]
        [StringLength(15)]
        public string AccNumber { get; set; }
        [Column("Notification_Message")]
        [StringLength(50)]
        public string NotificationMessage { get; set; }
    }
}
