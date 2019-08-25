using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sinemapp.Admin.Models
{
    public class GenreViewModel
    {
        public Guid Id { get; set; }
        [Display(Name = "Tür Adı")]
        [Required]
        public string GenreName { get; set; }
        [Display(Name = "Film Adı")]
        [Required]
        public Guid? FilmId { get; set; }
    }
}