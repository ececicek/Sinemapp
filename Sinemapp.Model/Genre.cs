using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinemapp.Model
{
    public class Genre:BaseEntity
    {
        public string GenreName { get; set; }
        public Guid? CinemaId { get; set; }
        public virtual Cinema Cinema { get; set; }
    }
}
