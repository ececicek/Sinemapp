using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinemapp.Model
{
    public class Genre:BaseEntity
    {
        public GenreName GenreName { get; set; }
        public Guid? FilmId { get; set; }
        public virtual Film Film { get; set; }
    }
}
