using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HuperFinance.Core.Responses
{
    public class Response<TData>
    {
        [JsonConstructor]
        public Response() => _code = Configuration.DefaultStatusCode;
        public Response(
            TData? data,
            int code = Configuration.DefaultStatusCode,
            string? message = null)
        {
            Data = data;
            _code = code;
            Message = message;

               
        }

        private int _code = Configuration.DefaultStatusCode;
        private string? Message { get; set; }

        public TData Data { get; set; }

        [JsonIgnore]
        public bool IsSucess => _code is >= 200 and <= 299;
    }
}
