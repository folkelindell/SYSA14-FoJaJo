﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebService
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CronusContext : DbContext
    {
        public CronusContext()
            : base("name=CronusContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<CRONUS_Sverige_AB_Employee> CRONUS_Sverige_AB_Employee { get; set; }
        public virtual DbSet<CRONUS_Sverige_AB_Employee_Absence> CRONUS_Sverige_AB_Employee_Absence { get; set; }
        public virtual DbSet<CRONUS_Sverige_AB_Employee_Portal_Setup> CRONUS_Sverige_AB_Employee_Portal_Setup { get; set; }
        public virtual DbSet<CRONUS_Sverige_AB_Employee_Qualification> CRONUS_Sverige_AB_Employee_Qualification { get; set; }
        public virtual DbSet<CRONUS_Sverige_AB_Employee_Relative> CRONUS_Sverige_AB_Employee_Relative { get; set; }
        public virtual DbSet<CRONUS_Sverige_AB_Employee_Statistics_Group> CRONUS_Sverige_AB_Employee_Statistics_Group { get; set; }
    }
}
