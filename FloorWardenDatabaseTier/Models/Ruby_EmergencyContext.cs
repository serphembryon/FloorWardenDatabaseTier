using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FloorWardenDatabaseTier.Models
{
    public partial class Ruby_EmergencyContext : DbContext
    {
        public Ruby_EmergencyContext()
        {
        }

        public Ruby_EmergencyContext(DbContextOptions<Ruby_EmergencyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<LinkEventEmployee> LinkEventEmployee { get; set; }
        public virtual DbSet<LinkWardenEmployee> LinkWardenEmployee { get; set; }
        public virtual DbSet<RefEmployeeStatus> RefEmployeeStatus { get; set; }
        public virtual DbSet<RefEventType> RefEventType { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=tcp:rubyemergency.database.usgovcloudapi.net,1433;Initial Catalog=Ruby_Emergency;Persist Security Info=False;User ID=ruby_admin;Password=Codfish78#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.EmployeeId).HasColumnName("Employee_Id");

                entity.Property(e => e.ActiveInd).HasColumnName("Active_Ind");

                entity.Property(e => e.Building)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Room)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WardenInd).HasColumnName("Warden_Ind");
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.Property(e => e.EventId).HasColumnName("Event_Id");

                entity.Property(e => e.ActiveInd).HasColumnName("Active_Ind");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("Date_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateEnded)
                    .HasColumnName("Date_Ended")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EventTypeId).HasColumnName("Event_Type_Id");
            });

            modelBuilder.Entity<LinkEventEmployee>(entity =>
            {
                entity.HasKey(e => e.LnkEventEmpId);

                entity.ToTable("Link_Event_Employee");

                entity.Property(e => e.LnkEventEmpId).HasColumnName("Lnk_Event_Emp_Id");

                entity.Property(e => e.ActiveInd).HasColumnName("Active_Ind");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("Date_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_Id");

                entity.Property(e => e.EmployeeStatusId).HasColumnName("Employee_Status_Id");

                entity.Property(e => e.EventId).HasColumnName("Event_Id");
            });

            modelBuilder.Entity<LinkWardenEmployee>(entity =>
            {
                entity.HasKey(e => e.LnkWardenEmpId);

                entity.ToTable("Link_Warden_Employee");

                entity.Property(e => e.LnkWardenEmpId)
                    .HasColumnName("Lnk_Warden_Emp_Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActiveInd).HasColumnName("Active_Ind");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("Date_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_Id");

                entity.Property(e => e.WardenId).HasColumnName("Warden_Id");
            });

            modelBuilder.Entity<RefEmployeeStatus>(entity =>
            {
                entity.HasKey(e => e.EmployeeStatusId);

                entity.ToTable("Ref_Employee_Status");

                entity.Property(e => e.EmployeeStatusId).HasColumnName("Employee_Status_Id");

                entity.Property(e => e.ActiveInd)
                    .HasColumnName("Active_Ind")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RefEventType>(entity =>
            {
                entity.HasKey(e => e.EventTypeId);

                entity.ToTable("Ref_Event_Type");

                entity.Property(e => e.EventTypeId).HasColumnName("Event_Type_Id");

                entity.Property(e => e.ActiveInd).HasColumnName("Active_Ind");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyType)
                    .IsRequired()
                    .HasColumnName("Emergency_Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Icon)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
