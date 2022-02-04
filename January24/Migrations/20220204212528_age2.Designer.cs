﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace January24.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20220204212528_age2")]
    partial class age2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.1");

            modelBuilder.Entity("January24.Kid", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Kids");
                });

            modelBuilder.Entity("January24.People", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age2")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("KidId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("KidId");

                    b.ToTable("Peoples");
                });

            modelBuilder.Entity("January24.People", b =>
                {
                    b.HasOne("January24.Kid", null)
                        .WithMany("Peoples")
                        .HasForeignKey("KidId");
                });

            modelBuilder.Entity("January24.Kid", b =>
                {
                    b.Navigation("Peoples");
                });
#pragma warning restore 612, 618
        }
    }
}
