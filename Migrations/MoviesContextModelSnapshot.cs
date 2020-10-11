﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YellowBucket1.Data;

namespace YellowBucket1.Migrations
{
    [DbContext(typeof(MoviesContext))]
    partial class MoviesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("YellowBucket1.Models.CustomerReviews", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MoviesID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("MoviesID");

                    b.ToTable("CustomerReviews");
                });

            modelBuilder.Entity("YellowBucket1.Models.Inventories", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("KiosksID")
                        .HasColumnType("int");

                    b.Property<int>("MoviesID")
                        .HasColumnType("int");

                    b.Property<int>("NumberBluRay")
                        .HasColumnType("int");

                    b.Property<int>("NumberBluRayRentedFrom")
                        .HasColumnType("int");

                    b.Property<int>("NumberDVD")
                        .HasColumnType("int");

                    b.Property<int>("NumberDVDRentedFrom")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("MoviesID");

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("YellowBucket1.Models.Kiosks", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Address2")
                        .IsRequired()
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("char(2)")
                        .HasMaxLength(2);

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Zip")
                        .IsRequired()
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.HasKey("ID");

                    b.ToTable("Kiosks");
                });

            modelBuilder.Entity("YellowBucket1.Models.Movies", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CoverPhoto")
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(4096)")
                        .HasMaxLength(4096);

                    b.Property<int?>("GenreID")
                        .HasColumnType("int");

                    b.Property<bool>("IsBluRay")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDVD")
                        .HasColumnType("bit");

                    b.Property<int?>("Length")
                        .HasColumnType("int");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("varchar(8)")
                        .HasMaxLength(30);

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(60);

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("YellowBucket1.Models.Rentals", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomersID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("InventoriesID")
                        .HasColumnType("int");

                    b.Property<int?>("KiosksID")
                        .HasColumnType("int");

                    b.Property<DateTime>("RentalDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RentalKiosksID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ReturnDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ReturnKiosksID")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("InventoriesID");

                    b.HasIndex("KiosksID");

                    b.ToTable("Rentals");
                });

            modelBuilder.Entity("YellowBucket1.Models.Wishlists", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MoviesID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("MoviesID");

                    b.ToTable("Wishlists");
                });

            modelBuilder.Entity("YellowBucket1.Models.CustomerReviews", b =>
                {
                    b.HasOne("YellowBucket1.Models.Movies", null)
                        .WithMany("CustomerReviews")
                        .HasForeignKey("MoviesID");
                });

            modelBuilder.Entity("YellowBucket1.Models.Inventories", b =>
                {
                    b.HasOne("YellowBucket1.Models.Movies", null)
                        .WithMany("Inventories")
                        .HasForeignKey("MoviesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("YellowBucket1.Models.Rentals", b =>
                {
                    b.HasOne("YellowBucket1.Models.Inventories", null)
                        .WithMany("Rentals")
                        .HasForeignKey("InventoriesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YellowBucket1.Models.Kiosks", null)
                        .WithMany("Rentals")
                        .HasForeignKey("KiosksID");
                });

            modelBuilder.Entity("YellowBucket1.Models.Wishlists", b =>
                {
                    b.HasOne("YellowBucket1.Models.Movies", null)
                        .WithMany("Wishlists")
                        .HasForeignKey("MoviesID");
                });
#pragma warning restore 612, 618
        }
    }
}