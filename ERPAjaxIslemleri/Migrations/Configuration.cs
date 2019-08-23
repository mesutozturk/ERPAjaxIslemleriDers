using ERPAjaxIslemleri.Models;

namespace ERPAjaxIslemleri.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ERPAjaxIslemleri.Models.AjaxContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ERPAjaxIslemleri.Models.AjaxContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            if (!context.Kisiler.Any())
                context.Kisiler.AddOrUpdate(
                    new Kisi() { Ad = "Kamil", Soyad = "Fýdýl", Tckn = "1111111111" },
                    new Kisi() { Ad = "Hakký", Soyad = "Demir", Tckn = "1111111110" }
                    );
        }
    }
}
