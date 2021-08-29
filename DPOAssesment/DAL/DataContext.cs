using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using DPOAssesment.Models;

namespace DPOAssesment.DAL
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DataContext")
        {

        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Comment> Comments { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}