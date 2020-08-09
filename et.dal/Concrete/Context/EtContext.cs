using et.documents.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace et.dal.Concrete.Context
{
   public class EtContext : DbContext
    {
        public DbSet<FirmEntity> Firms { get; set; }

    }
}
