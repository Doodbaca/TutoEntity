﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TutoEntity;

namespace TutoEntity.Migrations
{
    [DbContext(typeof(VaccinContext))]
    partial class VaccinContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("TutoEntity.TypeVaccin", b =>
                {
                    b.Property<int>("TypeVaccinId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TypeVaccinId");

                    b.ToTable("TypesVaccin");
                });

            modelBuilder.Entity("TutoEntity.Vaccin", b =>
                {
                    b.Property<int>("VaccinId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("NAMPatient")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TypeVaccinId")
                        .HasColumnType("int");

                    b.HasKey("VaccinId");

                    b.HasIndex("TypeVaccinId");

                    b.ToTable("Vaccins");
                });

            modelBuilder.Entity("TutoEntity.Vaccin", b =>
                {
                    b.HasOne("TutoEntity.TypeVaccin", "Type")
                        .WithMany()
                        .HasForeignKey("TypeVaccinId");

                    b.Navigation("Type");
                });
#pragma warning restore 612, 618
        }
    }
}
