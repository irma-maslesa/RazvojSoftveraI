﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _2_Vjezba.DBContext;

namespace _2_Vjezba.Migrations
{
    [DbContext(typeof(MojDBC))]
    [Migration("20201211215113_V6_PredmetOcjena")]
    partial class V6_PredmetOcjena
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Podaci.EntityModels.Ocjena", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<int>("OcjenaBroj")
                        .HasColumnType("int");

                    b.Property<int>("PredmetID")
                        .HasColumnType("int");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("PredmetID");

                    b.HasIndex("StudentID");

                    b.ToTable("Ocjene");
                });

            modelBuilder.Entity("Podaci.EntityModels.Predmet", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Predmet");
                });

            modelBuilder.Entity("_2_Vjezba.EntityModels.Opcina", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Opcina");
                });

            modelBuilder.Entity("_2_Vjezba.EntityModels.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("BrojIndeksa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OpcinaPrebivalistaID")
                        .HasColumnType("int");

                    b.Property<int>("OpcinaRodjenjaID")
                        .HasColumnType("int");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("OpcinaPrebivalistaID");

                    b.HasIndex("OpcinaRodjenjaID");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("Podaci.EntityModels.Ocjena", b =>
                {
                    b.HasOne("Podaci.EntityModels.Predmet", "Predmet")
                        .WithMany()
                        .HasForeignKey("PredmetID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_2_Vjezba.EntityModels.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Predmet");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("_2_Vjezba.EntityModels.Student", b =>
                {
                    b.HasOne("_2_Vjezba.EntityModels.Opcina", "OpcinaPrebivalista")
                        .WithMany()
                        .HasForeignKey("OpcinaPrebivalistaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_2_Vjezba.EntityModels.Opcina", "OpcinaRodjenja")
                        .WithMany()
                        .HasForeignKey("OpcinaRodjenjaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OpcinaPrebivalista");

                    b.Navigation("OpcinaRodjenja");
                });
#pragma warning restore 612, 618
        }
    }
}
