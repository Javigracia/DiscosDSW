using LearnMvc.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LearnMvc.DataAccess
{
    public class SalesERPDAL : DbContext
    {
        public DbSet<Cliente> Employees { get; set; }

        // no necesario ya que si se llama igual que en webconfig no hace falta
        public SalesERPDAL()
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            base.OnModelCreating(modelBuilder);
        }
    }
}