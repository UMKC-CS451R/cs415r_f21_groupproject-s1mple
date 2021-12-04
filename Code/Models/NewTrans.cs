using System.ComponentModel.DataAnnotations;

namespace Commerece.Models
{
    public class NewTrans
    {
      [Key]
            public string TransactionId { get; set; }
    
            public string AccountNo { get; set; }

            public string TransactionType { get; set; }
            public double? Amount { get; set; }
            public double? Balance { get; set; }

            public System.DateTime ProcessingDate { get; set; }
   
            public string Description { get; set; }

            public string Location { get; set; }
        
    }
}
