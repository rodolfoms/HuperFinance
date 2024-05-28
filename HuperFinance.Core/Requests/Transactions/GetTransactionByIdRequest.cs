using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuperFinance.Core.Requests.Transactions
{
    public class GetTransactionByIdRequest : Request
    {
        public uint Id { get; set; }
    }
}
