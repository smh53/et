using et.documents.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace et.dal.Concrete.Context
{
    public class EtContext : DbContext, IEtConext
    {
       
        public EtContext(DbContextOptions<EtContext> options) : base(options)
        {
            
        }
        public DbSet<FirmEntity> Firms { get; set; }
    }

    public interface IEtConext
    {
        
    }
}
