﻿// <auto-generated />
using System;
using JuliRennen.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JuliRennen.Migrations
{
    [DbContext(typeof(JuliRennenContext))]
    [Migration("20220801091723_newLocalDB")]
    partial class newLocalDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("JuliRennen.Models.Route", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<double>("Distance")
                        .HasColumnType("float");

                    b.Property<double>("GPSxEnd")
                        .HasColumnType("float");

                    b.Property<double>("GPSxStart")
                        .HasColumnType("float");

                    b.Property<double>("GPSyEnd")
                        .HasColumnType("float");

                    b.Property<double>("GPSyStart")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("Route");
                });

            modelBuilder.Entity("JuliRennen.Models.Run", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("DateAndTime")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("time");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<int?>("RouteID")
                        .HasColumnType("int");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("RouteID");

                    b.HasIndex("UserID");

                    b.ToTable("Run");
                });

            modelBuilder.Entity("JuliRennen.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<string>("ProfilePic")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SetPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SpeedPref")
                        .HasColumnType("bit");

                    b.Property<bool>("StaminaPref")
                        .HasColumnType("bit");

                    b.Property<bool>("StrengthPref")
                        .HasColumnType("bit");

                    b.Property<bool>("StretchPref")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("JuliRennen.Models.Route", b =>
                {
                    b.HasOne("JuliRennen.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID");

                    b.Navigation("User");
                });

            modelBuilder.Entity("JuliRennen.Models.Run", b =>
                {
                    b.HasOne("JuliRennen.Models.Route", "Route")
                        .WithMany()
                        .HasForeignKey("RouteID");

                    b.HasOne("JuliRennen.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID");

                    b.Navigation("Route");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
