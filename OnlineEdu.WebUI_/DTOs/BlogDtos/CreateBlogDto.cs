using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.WebUI_.DTOs.BlogDtos
{
    public class CreateBlogDto
    {
        public string Title { get; set; }
        public string Comment { get; set; }
        public string ImageUrl { get; set; }
        public DateTime BlogDate { get; set; }=DateTime.Now;
        public int BlogCategoryId { get; set; }
    }
}
