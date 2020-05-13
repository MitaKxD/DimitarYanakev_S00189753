namespace DimitarYanakev_S00189753.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DimitarYanakev_S00189753.PhoneData>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "DimitarYanakev_S00189753.PhoneData";
        }

        protected override void Seed(DimitarYanakev_S00189753.PhoneData context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
