﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RubyEntityFramework
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Ruby_EmergencyEntities : DbContext
    {
        public Ruby_EmergencyEntities()
            : base("name=Ruby_EmergencyEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Ref_Employee_Status> Ref_Employee_Status { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Ref_Event_Type> Ref_Event_Type { get; set; }
    }
}