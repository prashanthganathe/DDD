using CZ.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ.Infra.Data.Migrations
{
    public class DBInitializer : DropCreateDatabaseAlways<DomainContext>
    {
        protected override void Seed(DomainContext context)
        {
            //IList<Standard> defaultStandards = new List<Standard>();

            //defaultStandards.Add(new Standard() { StandardName = "Standard 1", Description = "First Standard" });
            //defaultStandards.Add(new Standard() { StandardName = "Standard 2", Description = "Second Standard" });
            //defaultStandards.Add(new Standard() { StandardName = "Standard 3", Description = "Third Standard" });

            //foreach (Standard std in defaultStandards)
            //    context.Standards.Add(std);

            base.Seed(context);
        }
    }
}
