﻿// <auto-generated />
using System;
using DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataLayer.Migrations
{
    [DbContext(typeof(RestaurantContext))]
    [Migration("20230418193125_Fix_Shift_TableShift_FK")]
    partial class Fix_Shift_TableShift_FK
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BusinessLayer.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .HasColumnType("int")
                        .HasColumnName("RoleID");

                    b.Property<string>("RoleName")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("BusinessLayer.Models.Shift", b =>
                {
                    b.Property<int>("ShiftId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShiftId"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Payrate")
                        .HasColumnType("float");

                    b.HasKey("ShiftId");

                    b.ToTable("Shifts");

                    b.HasData(
                        new
                        {
                            ShiftId = 1,
                            Description = "FirstShift",
                            Payrate = 5.0
                        },
                        new
                        {
                            ShiftId = 2,
                            Description = "SecondShift",
                            Payrate = 5.0
                        });
                });

            modelBuilder.Entity("BusinessLayer.Models.Table", b =>
                {
                    b.Property<int>("TableId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TableId"), 1L, 1);

                    b.Property<bool>("IsInside")
                        .HasColumnType("bit");

                    b.Property<int>("SeatCount")
                        .HasColumnType("int");

                    b.HasKey("TableId");

                    b.ToTable("Tables");

                    b.HasData(
                        new
                        {
                            TableId = 1,
                            IsInside = true,
                            SeatCount = 6
                        },
                        new
                        {
                            TableId = 2,
                            IsInside = true,
                            SeatCount = 6
                        },
                        new
                        {
                            TableId = 3,
                            IsInside = true,
                            SeatCount = 6
                        },
                        new
                        {
                            TableId = 4,
                            IsInside = true,
                            SeatCount = 6
                        },
                        new
                        {
                            TableId = 5,
                            IsInside = true,
                            SeatCount = 6
                        },
                        new
                        {
                            TableId = 6,
                            IsInside = true,
                            SeatCount = 6
                        });
                });

            modelBuilder.Entity("BusinessLayer.Models.TableShift", b =>
                {
                    b.Property<int>("TableId")
                        .HasColumnType("int");

                    b.Property<int>("ShiftId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ShiftDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Late")
                        .HasColumnType("bit");

                    b.Property<bool>("MissedShift")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("TableId", "ShiftId", "ShiftDate");

                    b.HasIndex("ShiftId");

                    b.HasIndex("UserId");

                    b.ToTable("TableShifts");
                });

            modelBuilder.Entity("BusinessLayer.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("Password")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int")
                        .HasColumnName("RoleID");

                    b.Property<string>("UserName")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("UserId");

                    b.HasIndex("RoleId");

                    b.HasIndex(new[] { "UserName" }, "IX_Users")
                        .IsUnique()
                        .HasFilter("[UserName] IS NOT NULL");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BusinessLayer.Models.UserVacation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserVacations");
                });

            modelBuilder.Entity("BusinessLayer.Models.TableShift", b =>
                {
                    b.HasOne("BusinessLayer.Models.Shift", "Shift")
                        .WithMany("TableShifts")
                        .HasForeignKey("ShiftId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusinessLayer.Models.Table", null)
                        .WithMany("TableShifts")
                        .HasForeignKey("TableId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusinessLayer.Models.User", "User")
                        .WithMany("TableShifts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_TableShifts_Users");

                    b.Navigation("Shift");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BusinessLayer.Models.User", b =>
                {
                    b.HasOne("BusinessLayer.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("BusinessLayer.Models.UserVacation", b =>
                {
                    b.HasOne("BusinessLayer.Models.User", "User")
                        .WithMany("UserVacations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_UserVacations_Users");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BusinessLayer.Models.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("BusinessLayer.Models.Shift", b =>
                {
                    b.Navigation("TableShifts");
                });

            modelBuilder.Entity("BusinessLayer.Models.Table", b =>
                {
                    b.Navigation("TableShifts");
                });

            modelBuilder.Entity("BusinessLayer.Models.User", b =>
                {
                    b.Navigation("TableShifts");

                    b.Navigation("UserVacations");
                });
#pragma warning restore 612, 618
        }
    }
}
