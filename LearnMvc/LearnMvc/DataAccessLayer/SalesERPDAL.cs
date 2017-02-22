using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using LearnMvc.Models;

namespace LearnMvc.DataAccessLayer
{
    public class SalesERPDAL: DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("TblEmployee");
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Cliente> Employees { get; set; }
    }
}