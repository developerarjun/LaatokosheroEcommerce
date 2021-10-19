﻿// <auto-generated />
using System;
using LaatokosheroBackEnd.src.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LaatokosheroBackEnd.Config.MigrationFiles
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("LaatokosheroBackEnd.src.Model.Profile.AdminProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ContactAddress")
                        .HasColumnType("longtext");

                    b.Property<string>("ContactAvailableTime")
                        .HasColumnType("longtext");

                    b.Property<string>("ContactNumber")
                        .HasColumnType("longtext");

                    b.Property<string>("FacebookUrl")
                        .HasColumnType("longtext");

                    b.Property<string>("InstagramUrl")
                        .HasColumnType("longtext");

                    b.Property<string>("TwitterUrl")
                        .HasColumnType("longtext");

                    b.Property<string>("YoutubeUrl")
                        .HasColumnType("longtext");

                    b.Property<byte[]>("logoImage")
                        .HasColumnType("Blob");

                    b.HasKey("Id");

                    b.ToTable("AdminProfiles");
                });

            modelBuilder.Entity("LaatokosheroBackEnd.src.Model.Profile.AdminUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("MiddleName")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("UserName")
                        .HasColumnType("int");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("AdminUsers");
                });

            modelBuilder.Entity("LaatokosheroBackEnd.src.Model.Profile.UserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("LaatokosheroBackEnd.src.Model.RolePermission.Role", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("id");

                    b.HasIndex("RoleName")
                        .IsUnique();

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("LaatokosheroBackEnd.src.Model.Profile.UserRole", b =>
                {
                    b.HasOne("LaatokosheroBackEnd.src.Model.RolePermission.Role", "Roles")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LaatokosheroBackEnd.src.Model.Profile.AdminUser", "AdminUsers")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AdminUsers");

                    b.Navigation("Roles");
                });
#pragma warning restore 612, 618
        }
    }
}
