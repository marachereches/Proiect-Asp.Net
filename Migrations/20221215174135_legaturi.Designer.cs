﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proiect.Data;

#nullable disable

namespace Proiect.Migrations
{
    [DbContext(typeof(ProiectContext))]
    [Migration("20221215174135_legaturi")]
    partial class legaturi
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Proiect.Models.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("NrPers")
                        .HasColumnType("int");

                    b.Property<string>("Nume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OrasID")
                        .HasColumnType("int");

                    b.Property<decimal?>("PretCamera")
                        .HasColumnType("decimal(6,2)");

                    b.Property<int?>("Rating")
                        .HasColumnType("int");

                    b.Property<int?>("TaraID")
                        .HasColumnType("int");

                    b.Property<string>("TipCamera")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OrasID");

                    b.HasIndex("TaraID");

                    b.ToTable("Hotel");
                });

            modelBuilder.Entity("Proiect.Models.Oras", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descriere")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TaraID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TaraID");

                    b.ToTable("Oras");
                });

            modelBuilder.Entity("Proiect.Models.Prezentare", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("HotelID")
                        .HasColumnType("int");

                    b.Property<int?>("OrasID")
                        .HasColumnType("int");

                    b.Property<int?>("TaraID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HotelID");

                    b.HasIndex("OrasID");

                    b.HasIndex("TaraID");

                    b.ToTable("Prezentare");
                });

            modelBuilder.Entity("Proiect.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("HotelID")
                        .HasColumnType("int");

                    b.Property<int?>("OrasID")
                        .HasColumnType("int");

                    b.Property<string>("Parere")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TaraID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HotelID");

                    b.HasIndex("OrasID");

                    b.HasIndex("TaraID");

                    b.ToTable("Review");
                });

            modelBuilder.Entity("Proiect.Models.Rezervare", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("DataPlecare")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataSosire")
                        .HasColumnType("datetime2");

                    b.Property<int?>("HotelID")
                        .HasColumnType("int");

                    b.Property<string>("Nume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OrasID")
                        .HasColumnType("int");

                    b.Property<int?>("Persoane")
                        .HasColumnType("int");

                    b.Property<string>("Prenume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TaraID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HotelID");

                    b.HasIndex("OrasID");

                    b.HasIndex("TaraID");

                    b.ToTable("Rezervare");
                });

            modelBuilder.Entity("Proiect.Models.Tara", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Continent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nume")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Tara");
                });

            modelBuilder.Entity("Proiect.Models.Hotel", b =>
                {
                    b.HasOne("Proiect.Models.Oras", "Oras")
                        .WithMany("Hoteluri")
                        .HasForeignKey("OrasID");

                    b.HasOne("Proiect.Models.Tara", "Tara")
                        .WithMany("Hoteluri")
                        .HasForeignKey("TaraID");

                    b.Navigation("Oras");

                    b.Navigation("Tara");
                });

            modelBuilder.Entity("Proiect.Models.Oras", b =>
                {
                    b.HasOne("Proiect.Models.Tara", "Tara")
                        .WithMany("Orase")
                        .HasForeignKey("TaraID");

                    b.Navigation("Tara");
                });

            modelBuilder.Entity("Proiect.Models.Prezentare", b =>
                {
                    b.HasOne("Proiect.Models.Hotel", "Hotel")
                        .WithMany("Prezentari")
                        .HasForeignKey("HotelID");

                    b.HasOne("Proiect.Models.Oras", "Oras")
                        .WithMany("Prezentari")
                        .HasForeignKey("OrasID");

                    b.HasOne("Proiect.Models.Tara", "Tara")
                        .WithMany("Prezentari")
                        .HasForeignKey("TaraID");

                    b.Navigation("Hotel");

                    b.Navigation("Oras");

                    b.Navigation("Tara");
                });

            modelBuilder.Entity("Proiect.Models.Review", b =>
                {
                    b.HasOne("Proiect.Models.Hotel", "Hotel")
                        .WithMany("Reviews")
                        .HasForeignKey("HotelID");

                    b.HasOne("Proiect.Models.Oras", "Oras")
                        .WithMany("Reviews")
                        .HasForeignKey("OrasID");

                    b.HasOne("Proiect.Models.Tara", "Tara")
                        .WithMany("Reviews")
                        .HasForeignKey("TaraID");

                    b.Navigation("Hotel");

                    b.Navigation("Oras");

                    b.Navigation("Tara");
                });

            modelBuilder.Entity("Proiect.Models.Rezervare", b =>
                {
                    b.HasOne("Proiect.Models.Hotel", "Hotel")
                        .WithMany()
                        .HasForeignKey("HotelID");

                    b.HasOne("Proiect.Models.Oras", "Oras")
                        .WithMany("Rezervari")
                        .HasForeignKey("OrasID");

                    b.HasOne("Proiect.Models.Tara", "Tara")
                        .WithMany("Rezervari")
                        .HasForeignKey("TaraID");

                    b.Navigation("Hotel");

                    b.Navigation("Oras");

                    b.Navigation("Tara");
                });

            modelBuilder.Entity("Proiect.Models.Hotel", b =>
                {
                    b.Navigation("Prezentari");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("Proiect.Models.Oras", b =>
                {
                    b.Navigation("Hoteluri");

                    b.Navigation("Prezentari");

                    b.Navigation("Reviews");

                    b.Navigation("Rezervari");
                });

            modelBuilder.Entity("Proiect.Models.Tara", b =>
                {
                    b.Navigation("Hoteluri");

                    b.Navigation("Orase");

                    b.Navigation("Prezentari");

                    b.Navigation("Reviews");

                    b.Navigation("Rezervari");
                });
#pragma warning restore 612, 618
        }
    }
}
