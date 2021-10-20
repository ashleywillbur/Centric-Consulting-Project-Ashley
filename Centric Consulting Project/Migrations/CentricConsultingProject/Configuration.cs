namespace Centric_Consulting_Project.Migrations.CentricConsultingProject
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Centric_Consulting_Project.DAL.CentricConsultingProjectContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"Migrations\CentricConsultingProject";
            ContextKey = "Centric_Consulting_Project.DAL.CentricConsultingProjectContext";
        }

        protected override void Seed(Centric_Consulting_Project.DAL.CentricConsultingProjectContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
