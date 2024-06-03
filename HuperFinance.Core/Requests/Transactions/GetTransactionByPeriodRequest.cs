using HuperFinance.Core.Requests;

namespace HuperFinance.Core.Requests.Transactions;

public class GetTransactionsByPeriodRequest : PagedRequest
{
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
}