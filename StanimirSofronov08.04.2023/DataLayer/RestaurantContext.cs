using System;
using System.Collections.Generic;
using BusinessLayer;
using BusinessLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataLayer
{
    public partial class RestaurantContext : DbContext
    {
        // Package Manager Console -> Default project: DataLayer
        // - > run following to create new migration: add-migration TheMigrationName
        // - > run the following to update the database: update-database

        public RestaurantContext()
        {
        }

        public RestaurantContext(DbContextOptions<RestaurantContext> options)
            : base(options)
        {
        }

        //public virtual DbSet<Function> Functions { get; set; } = null!;

        public virtual DbSet<Role> Roles { get; set; } = null!;

        public virtual DbSet<User> Users { get; set; } = null!;

        public virtual DbSet<UserVacation> UserVacations { get; set; } = null!;

        public virtual DbSet<Table> Tables { get; set; } = null!;

        public virtual DbSet<Shift> Shifts { get; set; } = null!;

        public virtual DbSet<TableShift> TableShifts { get; set; } = null!;


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-JARQ3N6;Database=RestaurantDb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Function>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.Property(e => e.FormName)
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.FunctionId)
            //        .ValueGeneratedOnAdd()
            //        .HasColumnName("FunctionID");

            //    entity.Property(e => e.FunctionName)
            //        .HasMaxLength(50)
            //        .IsUnicode(false);
            //});

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.RoleId)
                    .ValueGeneratedNever()
                    .HasColumnName("RoleID");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasMany(r => r.Users)
                    .WithOne(u => u.Role)
                    .HasForeignKey(u => u.UserId);
                //  .HasConstraintName("FK_Users_Roles");
            });


            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.UserName, "IX_Users")
                    .IsUnique();

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId);
                //   .HasConstraintName("FK_Users_Roles");
            });

            modelBuilder.Entity<UserVacation>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.StartDate);

                entity.Property(e => e.EndDate);

                entity.HasOne(uv => uv.User)
                    .WithMany(u => u.UserVacations)
                    .HasForeignKey(us => us.UserId)
                    .HasConstraintName("FK_UserVacations_Users");
            });

            modelBuilder.Entity<Table>(entity =>
            {
                entity.HasKey(e => e.TableId);

                entity.Property(e => e.SeatCount);

                entity.Property(e => e.IsInside);
            });
            modelBuilder.Entity<Table>().HasData(
                  new Table { TableId = 1, SeatCount = 6, IsInside = true },
                  new Table { TableId = 2, SeatCount = 6, IsInside = true },
                  new Table { TableId = 3, SeatCount = 6, IsInside = true },
                  new Table { TableId = 4, SeatCount = 6, IsInside = true },
                  new Table { TableId = 5, SeatCount = 6, IsInside = true },
                  new Table { TableId = 6, SeatCount = 6, IsInside = true }
                );



            modelBuilder.Entity<Shift>(entity =>
            {
                entity.HasKey(e => e.ShiftId);

                entity.Property(e => e.Description);

                entity.Property(e => e.Payrate);
            });
            modelBuilder.Entity<Shift>().HasData(
                new Shift { ShiftId = 1, Description = "FirstShift", Payrate = 5 },
                new Shift { ShiftId = 2, Description = "SecondShift", Payrate = 5 }
                );

            modelBuilder.Entity<TableShift>(entity =>
            {
                entity.HasKey(e => new { e.TableId, e.ShiftId, e.ShiftDate });

                entity.HasOne(ts => ts.User)
                    .WithMany(u => u.TableShifts)
                    .HasForeignKey(ts => ts.UserId)
                    .HasConstraintName("FK_TableShifts_Users");

                entity.Property(e => e.Late);

                entity.Property(e => e.MissedShift);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        /* private void Seed()
         {
             var firstShift = new Shift()
             {
                 ShiftId = 1,
                 Description = "First Shift",
                 Payrate = 5
             };
             var secondShift = new Shift()
             {
                 ShiftId = 1,
                 Description = "Second Shift",
                 Payrate = 5
             };
        }
        */


        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
