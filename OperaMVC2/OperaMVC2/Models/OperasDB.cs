using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OperaMVC2.Models
{
    public class OperasDB : DbContext
    {
        public DbSet<Opera> Operas { get; set; }
    }
}