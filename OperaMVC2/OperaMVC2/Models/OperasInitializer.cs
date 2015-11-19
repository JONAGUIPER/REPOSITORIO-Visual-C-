using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OperaMVC2.Models
{
    public class OperasInitializer : CreateDatabaseIfNotExists<OperasDB>
    {
        protected override void Seed(OperasDB context)
        {
            base.Seed(context);
            var operas = new List<Opera>()
            {
                new Opera()
                {
                    Title = "Cosi Fan Tutte",
                    Year = 1790,
                    Composer = "Mozart"
                }
            };
            operas.ForEach(s => context.Operas.Add(s));
            context.SaveChanges();

        }
    }
}