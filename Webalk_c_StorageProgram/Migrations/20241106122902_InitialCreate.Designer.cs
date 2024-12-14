﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace Webalk_c_StorageProgram.Migrations
{
    [DbContext(typeof(RaktarAlkalmazasContext))]
    [Migration("20241106122902_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Berles_Vasarlas", b =>
                {
                    b.Property<int>("TranzakcioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TranzakcioId"));

                    b.Property<decimal>("Ar")
                        .HasColumnType("DECIMAL(18, 2)");

                    b.Property<int>("FelhasznaloId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<DateTime>("KezdesDatum")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<int>("RaktarId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Tipus")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<DateTime?>("VegDatum")
                        .HasColumnType("TIMESTAMP(7)");

                    b.HasKey("TranzakcioId");

                    b.HasIndex("FelhasznaloId");

                    b.HasIndex("RaktarId");

                    b.ToTable("Berles_Vasarlas");
                });

            modelBuilder.Entity("Esemeny_Resztvevok", b =>
                {
                    b.Property<int>("ResztvevoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ResztvevoId"));

                    b.Property<int>("EsemenyId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("FelhasznaloId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("ResztvevoId");

                    b.HasIndex("EsemenyId");

                    b.HasIndex("FelhasznaloId");

                    b.ToTable("Esemény_Resztvevok");
                });

            modelBuilder.Entity("Esemenyek", b =>
                {
                    b.Property<int>("EsemenyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EsemenyId"));

                    b.Property<DateTime>("Datum")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("EsemenyNev")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Helyszin")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("NVARCHAR2(255)");

                    b.Property<string>("Leiras")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("EsemenyId");

                    b.ToTable("Esemenyek");
                });

            modelBuilder.Entity("Felhasznalok", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.Property<string>("Jelszo")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("KedvencTema")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Neme")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Nev")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.Property<DateTime?>("SzuletesiDatum")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("SzuletesiHely")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.Property<string>("TemaSzine")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("NVARCHAR2(7)");

                    b.HasKey("Id");

                    b.ToTable("Felhasznalok");
                });

            modelBuilder.Entity("Raktarak", b =>
                {
                    b.Property<int>("RaktarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RaktarId"));

                    b.Property<decimal>("ArBerles")
                        .HasColumnType("DECIMAL(18, 2)");

                    b.Property<decimal>("ArVetel")
                        .HasColumnType("DECIMAL(18, 2)");

                    b.Property<string>("Cim")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("NVARCHAR2(255)");

                    b.Property<string>("RaktarSzam")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)");

                    b.Property<float>("Terulet")
                        .HasColumnType("BINARY_FLOAT");

                    b.Property<int?>("TulajdonosId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("RaktarId");

                    b.HasIndex("TulajdonosId");

                    b.ToTable("Raktarak");
                });

            modelBuilder.Entity("Berles_Vasarlas", b =>
                {
                    b.HasOne("Felhasznalok", "Felhasznalo")
                        .WithMany()
                        .HasForeignKey("FelhasznaloId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Raktarak", "Raktar")
                        .WithMany()
                        .HasForeignKey("RaktarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Felhasznalo");

                    b.Navigation("Raktar");
                });

            modelBuilder.Entity("Esemeny_Resztvevok", b =>
                {
                    b.HasOne("Esemenyek", "Esemeny")
                        .WithMany()
                        .HasForeignKey("EsemenyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Felhasznalok", "Felhasznalo")
                        .WithMany()
                        .HasForeignKey("FelhasznaloId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Esemeny");

                    b.Navigation("Felhasznalo");
                });

            modelBuilder.Entity("Raktarak", b =>
                {
                    b.HasOne("Felhasznalok", "Tulajdonos")
                        .WithMany()
                        .HasForeignKey("TulajdonosId");

                    b.Navigation("Tulajdonos");
                });
#pragma warning restore 612, 618
        }
    }
}