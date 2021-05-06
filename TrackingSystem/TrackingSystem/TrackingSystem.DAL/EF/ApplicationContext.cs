using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingSystem.DAL.Entities;

namespace TrackingSystem.DAL.EF
{
    public class ApplicationContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationContext(string conectionString) : base(conectionString) { }
        public ApplicationContext() : base() { }
        public DbSet<ClientProfile> ClientProfiles { get; set; }
        public DbSet<Tasks> Task { get; set; }
        public DbSet<Courses> Cours { get; set; }
    }
}
