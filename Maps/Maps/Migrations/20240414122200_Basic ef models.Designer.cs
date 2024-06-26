﻿// <auto-generated />
using Maps.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetTopologySuite.Geometries;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Maps.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20240414122200_Basic ef models")]
    partial class Basicefmodels
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.HasPostgresExtension(modelBuilder, "postgis");
            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Maps.Persistence.PMF_Map", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<byte[]>("Bytes")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("PMF_Map", (string)null);
                });

            modelBuilder.Entity("Maps.Persistence.PMF_Map_Attributes", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PMF_MapID")
                        .HasColumnType("integer");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.HasIndex("PMF_MapID");

                    b.ToTable("PMF_Map_Attributes", (string)null);
                });

            modelBuilder.Entity("Maps.Persistence.PMF_Map_POI", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PMF_MapID")
                        .HasColumnType("integer");

                    b.Property<Point>("Point")
                        .IsRequired()
                        .HasColumnType("geometry");

                    b.HasKey("ID");

                    b.HasIndex("PMF_MapID");

                    b.ToTable("PMF_Map_POIs", (string)null);
                });

            modelBuilder.Entity("Maps.Persistence.PMF_Map_Polygon", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PMF_MapID")
                        .HasColumnType("integer");

                    b.Property<Polygon>("Polygon")
                        .IsRequired()
                        .HasColumnType("geometry");

                    b.HasKey("ID");

                    b.HasIndex("PMF_MapID");

                    b.ToTable("PMF_Map_Polygons", (string)null);
                });

            modelBuilder.Entity("Maps.Persistence.PMF_Map_Polyline", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<int>("End_level")
                        .HasColumnType("integer");

                    b.Property<LineString>("LineString")
                        .IsRequired()
                        .HasColumnType("geometry");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PMF_MapID")
                        .HasColumnType("integer");

                    b.Property<int>("Start_level")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.HasIndex("PMF_MapID");

                    b.ToTable("PMF_Map_Polylines", (string)null);
                });

            modelBuilder.Entity("Maps.Persistence.PMF_Map_Attributes", b =>
                {
                    b.HasOne("Maps.Persistence.PMF_Map", "PMF_Map")
                        .WithMany()
                        .HasForeignKey("PMF_MapID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PMF_Map");
                });

            modelBuilder.Entity("Maps.Persistence.PMF_Map_POI", b =>
                {
                    b.HasOne("Maps.Persistence.PMF_Map", "PMF_Map")
                        .WithMany("POIs")
                        .HasForeignKey("PMF_MapID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PMF_Map");
                });

            modelBuilder.Entity("Maps.Persistence.PMF_Map_Polygon", b =>
                {
                    b.HasOne("Maps.Persistence.PMF_Map", "PMF_Map")
                        .WithMany("Polygons")
                        .HasForeignKey("PMF_MapID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PMF_Map");
                });

            modelBuilder.Entity("Maps.Persistence.PMF_Map_Polyline", b =>
                {
                    b.HasOne("Maps.Persistence.PMF_Map", "PMF_Map")
                        .WithMany("Polylines")
                        .HasForeignKey("PMF_MapID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PMF_Map");
                });

            modelBuilder.Entity("Maps.Persistence.PMF_Map", b =>
                {
                    b.Navigation("POIs");

                    b.Navigation("Polygons");

                    b.Navigation("Polylines");
                });
#pragma warning restore 612, 618
        }
    }
}
