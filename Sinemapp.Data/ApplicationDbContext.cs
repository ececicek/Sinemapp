using Microsoft.AspNet.Identity.EntityFramework;
using Sinemapp.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinemapp.Data
{  
        public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
        {
            public ApplicationDbContext()
                : base("DefaultConnection", throwIfV1Schema: false)
            {
            }

            public static ApplicationDbContext Create()
            {
                return new ApplicationDbContext();
            }

        public virtual DbSet<Film> Cinemas { get; set; }
        public virtual DbSet<Cast> Casts { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<News> Newses { get; set; }

        }
    
}
