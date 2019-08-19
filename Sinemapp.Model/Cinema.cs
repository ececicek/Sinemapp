using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinemapp.Model
{
    public class Cinema:BaseEntity
    {
        public string FilmName { get; set; }
        public string Rating { get; set; }
        public DateTime RunTime { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Director { get; set; }
        public string Writer { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
        public string NumOfViewer { get; set; }
        public string Revenue { get; set; }

        public ICollection<Genre> Genres { get; set; }
        public ICollection<Cast> Casts { get; set; }
    }
}
