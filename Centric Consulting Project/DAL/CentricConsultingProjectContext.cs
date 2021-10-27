using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Centric_Consulting_Project.Models;

namespace Centric_Consulting_Project.DAL
{
    public class CentricConsultingProjectContext : DbContext 
    {
        public CentricConsultingProjectContext() : base("name=DefaultConnection") 
        {
        }
            public DbSet<Profile> profiles { get; set; }

        public System.Data.Entity.DbSet<Centric_Consulting_Project.Models.Recognize> Recognizes { get; set; }
    }
}