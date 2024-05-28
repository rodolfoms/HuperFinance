using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuperFinance.Core.Requests.Categories
{
    public class DeleteCategoryRequest : Request
    {
        public uint Id { get; set; }
    }
}
