﻿//using Microsoft.Analytics.Interfaces;
//using Microsoft.Analytics.Types.Sql;
using Store.Data.Configuration;
using Store.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;

namespace Store.Data
{
    public class StoreEntities:DbContext
    {
        public StoreEntities():base("StoreEntities")
        {

        }

        public DbSet<Gadget> Gadgets{ get; set; }

        public DbSet<Category> Categories { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new GadgetConfiguration());
            modelBuilder.Configurations.Add(new CategoryConfiguration());
        }
    }
}