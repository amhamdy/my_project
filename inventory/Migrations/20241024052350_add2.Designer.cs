﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using cairo_library.data;

#nullable disable

namespace cairo_library.Migrations
{
    [DbContext(typeof(myappdpcontext))]
    [Migration("20241024052350_add2")]
    partial class add2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.35")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("cairo_library.Models.books", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bublishdate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Isbn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("checkoutsid")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("checkoutsid");

                    b.ToTable("books");
                });

            modelBuilder.Entity("cairo_library.Models.checkout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Checkout_date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Due_date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Librarian_id")
                        .HasColumnType("int");

                    b.Property<int>("Member_id")
                        .HasColumnType("int");

                    b.Property<string>("Penality_amount")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Return_date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("librariansId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Member_id");

                    b.HasIndex("librariansId");

                    b.ToTable("checkouts");
                });

            modelBuilder.Entity("cairo_library.Models.librarian", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hiredate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phonenumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("librarians");
                });

            modelBuilder.Entity("cairo_library.Models.member", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Membershipdate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phonenumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("members");
                });

            modelBuilder.Entity("cairo_library.Models.penality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Member_id")
                        .HasColumnType("int");

                    b.Property<string>("Payment_status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Penality_amount")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("membersId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("membersId");

                    b.ToTable("penalities");
                });

            modelBuilder.Entity("cairo_library.Models.books", b =>
                {
                    b.HasOne("cairo_library.Models.checkout", "checkouts")
                        .WithMany("books")
                        .HasForeignKey("checkoutsid");

                    b.Navigation("checkouts");
                });

            modelBuilder.Entity("cairo_library.Models.checkout", b =>
                {
                    b.HasOne("cairo_library.Models.member", "member")
                        .WithMany("Checkouts")
                        .HasForeignKey("Member_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("cairo_library.Models.librarian", "librarians")
                        .WithMany("Checkouts")
                        .HasForeignKey("librariansId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("librarians");

                    b.Navigation("member");
                });

            modelBuilder.Entity("cairo_library.Models.penality", b =>
                {
                    b.HasOne("cairo_library.Models.member", "members")
                        .WithMany("penalities")
                        .HasForeignKey("membersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("members");
                });

            modelBuilder.Entity("cairo_library.Models.checkout", b =>
                {
                    b.Navigation("books");
                });

            modelBuilder.Entity("cairo_library.Models.librarian", b =>
                {
                    b.Navigation("Checkouts");
                });

            modelBuilder.Entity("cairo_library.Models.member", b =>
                {
                    b.Navigation("Checkouts");

                    b.Navigation("penalities");
                });
#pragma warning restore 612, 618
        }
    }
}
