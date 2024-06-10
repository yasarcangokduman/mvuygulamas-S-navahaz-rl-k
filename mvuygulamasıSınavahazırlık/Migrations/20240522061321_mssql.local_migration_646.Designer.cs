﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mvuygulamasıSınavahazırlık.Models;

#nullable disable

namespace mvuygulamasıSınavahazırlık.Migrations
{
    [DbContext(typeof(HazirlikDbContext))]
    [Migration("20240522061321_mssql.local_migration_646")]
    partial class mssqllocal_migration_646
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("mvuygulamasıSınavahazırlık.Models.Ogrenci", b =>
                {
                    b.Property<int>("OgrenciId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OgrenciId"), 1L, 1);

                    b.Property<int>("SinifId")
                        .HasColumnType("int");

                    b.Property<string>("ogrenciAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ogrenciSoyadi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OgrenciId");

                    b.HasIndex("SinifId");

                    b.ToTable("Ogrenciler");
                });

            modelBuilder.Entity("mvuygulamasıSınavahazırlık.Models.Sinif", b =>
                {
                    b.Property<int>("SinifId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SinifId"), 1L, 1);

                    b.Property<string>("SinifAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SinifKodu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SinifId");

                    b.ToTable("Siniflar");
                });

            modelBuilder.Entity("mvuygulamasıSınavahazırlık.Models.Ogrenci", b =>
                {
                    b.HasOne("mvuygulamasıSınavahazırlık.Models.Sinif", "Sinif")
                        .WithMany("Ogrenciler")
                        .HasForeignKey("SinifId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sinif");
                });

            modelBuilder.Entity("mvuygulamasıSınavahazırlık.Models.Sinif", b =>
                {
                    b.Navigation("Ogrenciler");
                });
#pragma warning restore 612, 618
        }
    }
}
