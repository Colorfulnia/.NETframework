using EntityframeworkCodeFirst.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EntityframeworkCodeFirst
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<tbl_Educational_Details> tbl_Educational_Details { get; set; }
        public virtual DbSet<tbl_Employee_Master> tbl_Employee_Master { get; set; }
        public virtual DbSet<tbl_Error_Log> tbl_Error_Log { get; set; }
        public virtual DbSet<tbl_User_Master> tbl_User_Master { get; set; }
        public virtual DbSet<tbl_Desingation> Tbl_Desingations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tbl_Educational_Details>()
                .Property(e => e.Education)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Educational_Details>()
                .Property(e => e.University)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Educational_Details>()
                .Property(e => e.Grade_Obtained)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Educational_Details>()
                .Property(e => e.Passing_Year)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Employee_Master>()
                .Property(e => e.Contact_No)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Employee_Master>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Employee_Master>()
                .Property(e => e.Address_Line1)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Employee_Master>()
                .Property(e => e.Address_Line2)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Employee_Master>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Employee_Master>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Employee_Master>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Employee_Master>()
                .Property(e => e.Zip_Code)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Employee_Master>()
                .HasMany(e => e.tbl_Educational_Details)
                .WithRequired(e => e.tbl_Employee_Master)
                .WillCascadeOnDelete(false);
        }
    }
}
