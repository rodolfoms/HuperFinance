using HuperFinance.Core.Enuns;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuperFinance.Core.Requests.Transactions
{
    public class UpdateTransactionRequest : Request
    {
        public uint Id { get; set; }

        [Required(ErrorMessage = "Title empty")]
        [MaxLength(80, ErrorMessage = "MaxLenght = 80")]
        public String Title { get; set; } = string.Empty;


        [Required(ErrorMessage = "Type empty")]
        public ETransactionType Type { get; set; } = ETransactionType.Withdraw;


        [Required(ErrorMessage = "Amount empty")]
        public decimal Amount { get; set; }


        [Required(ErrorMessage = "Category empty")]
        public long CategoryId { get; set; }


        [Required(ErrorMessage = "Date empty")]
        public DateTime? PaidOrReceivedAt { get; set; }
    }
}
