using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFiratApproach.Models
{
    class BatchDbContext : DbContext
    {
        public BatchDbContext() { }
        public DbSet<Batch> Batches { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Batch>()
                 .ToTable("tblBatch");

            modelBuilder.Entity<Batch>().HasKey<int>(s => s.Code);




        }
    }
}
