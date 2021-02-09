using OkulProjesi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace OkulProjesi.Models.Context
{
    public class CrudContext : DbContext 
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public CrudContext()
        {
            Database.Connection.ConnectionString = "server=DESKTOP-2IPPHG8\\MSSQLSERVER1;database=OkulYonetimi;Trusted_Connection=true";
        }

        public DbSet <Ogrenci> Ogrenci  { get; set; }
        public DbSet <Ogretmen> Ogretmen { get; set; }
    }
}