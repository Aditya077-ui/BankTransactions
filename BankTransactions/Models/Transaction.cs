using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankTransactions.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        [Column(TypeName = "nvarchar(12)")]
        public int AccountNumber { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public int BeneficiaryName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public int BankName { get; set; }

        [Column(TypeName = "nvarchar(11)")]
        public int SWIFTCode { get; set; }

        
        public int Amount { get; set; }

        
        public DateTime Date { get; set; }

    }
}
