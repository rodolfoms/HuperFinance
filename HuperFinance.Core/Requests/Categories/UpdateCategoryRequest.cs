using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuperFinance.Core.Requests.Categories
{
    public class UpdateCategoryRequest : Request
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "Title empty")]
        [MaxLength(80, ErrorMessage = "MaxLenght = 80")]
        public String Title { get; set; } = string.Empty;
        public String? Description { get; set; }
    }
}
