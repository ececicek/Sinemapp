using Sinemapp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sinemapp.Admin.Models
{
    public class CastViewModel
    {
        public Guid Id { get; set; }
        [Display(Name="İsim")]
        [Required]
        public string FullName { get { return FirstName + " " + LastName; } }
        [Display(Name = "Ad")]
        [Required]
        public string FirstName { get; set; }
        [Display(Name = "Soyad")]
        [Required]
        public string LastName { get; set; }
        [Display(Name = "Doğum Tarihi")]
        public DateTime? BirthDate { get; set; }
        [Display(Name = "Cinsiyet")]
        public Gender? Gender { get; set; }
        [Display(Name = "Film")]
        [Required]
        public Guid? FilmId { get; set; }

    }
}