using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinemapp.Model
{
    public class News: BaseEntity 
    {
        public string Title { get; set; }
        public DateTime? NewsDate { get; set; }
        public string ByWhom { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
    }
}
