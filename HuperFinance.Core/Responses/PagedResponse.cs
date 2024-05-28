using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HuperFinance.Core.Responses
{
    
    public class PagedResponse<TData> : Response<TData>
    {
        [JsonConstructor]
        public PagedResponse(
            TData? data,
            int code = Configuration.DefaultPageSize,
            int totalCount = 1,
            int currentPage = 1,
            int pageSize = Configuration.DefaultPageSize)
            : base(data)
        {
            Data = data;
            TotalCount = totalCount;
            CurrentPage = currentPage;
            PageSize = pageSize;
        }

        public PagedResponse(
            TData? data,
            int code = Configuration.DefaultPageSize,
            string? message = null)
            : base(data)
        {
        }


        public int CurrentPage { get; set; }
        public int TotalPages => (int)Math.Ceiling(TotalCount / (double)PageSize); //Ceiling arredonda pra cima, ex 3.6 vai retornar 4
        public int PageSize { get; set; } = Configuration.DefaultPageSize;
        public int TotalCount { get; set; } = Configuration.DefaultPageNumber;
    }
}
