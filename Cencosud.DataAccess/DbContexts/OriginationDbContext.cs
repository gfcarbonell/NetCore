using Cencosud.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cencosud.DataAccess
{
    public class OriginationDbContext : DbContext, IOriginationDbContext
    {
        public OriginationDbContext(DbContextOptions<OriginationDbContext> options) :
            base(options)
        {

        }

        public OriginationDbContext()
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
