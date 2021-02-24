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
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("YellowBucket1.Models.CustomerReviews", b =>
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

                    b.Property<int?>("Kernals")
                        .HasColumnType("int");

                    b.Property<int>("MoviesID")
                        .HasColumnType("int");

                    b.Property<string>("Review")
                        .HasColumnType("varchar(4096)")
                        .HasMaxLength(4096);

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("CustomersID");

                    b.HasIndex("MoviesID");

                    b.ToTable("CustomerReviews");
                });

            modelBuilder.Entity("YellowBucket1.Models.Customers", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Address2")
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("City")
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("FirstName")
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("LasttName")
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Password")
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("State")
                        .HasColumnType("char(2)")
                        .HasMaxLength(2);

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Zip")
                        .HasColumnType("varchar(16)")
                        .HasMaxLength(16);

                    b.HasKey("ID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("YellowBucket1.Models.Genres", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(32)")
                        .HasMaxLength(32);

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Genres");
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

                    b.Property<DateTime?>("CreatedAt")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(4096)")
                        .HasMaxLength(4096);

                    b.Property<bool>("IsBluRay")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDVD")
                        .HasColumnType("bit");

                    b.Property<int?>("Length")
                        .HasColumnType("int");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Rating")
                        .HasColumnType("varchar(8)")
                        .HasMaxLength(8);

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.Property<DateTime?>("UpdatedAt")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("YellowBucket1.Models.MoviesGenres", b =>
                {
                    b.Property<int>("MoviesID")
                        .HasColumnType("int");

                    b.Property<int>("GenresID")
                        .HasColumnType("int");

                    b.HasKey("MoviesID", "GenresID");

                    b.HasIndex("GenresID");

                    b.ToTable("MoviesGenres");
                });

            modelBuilder.Entity("YellowBucket1.Models.Passwords", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CustomersID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Username");

                    b.HasIndex("CustomersID");

                    b.ToTable("Passwords");
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

                    b.Property<bool>("IsBluRay")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDVD")
                        .HasColumnType("bit");

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

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomersID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("MoviesID")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("CustomersID");

                    b.HasIndex("MoviesID");

                    b.ToTable("Wishlists");
                });

            modelBuilder.Entity("YellowBucket1.Models.CustomerReviews", b =>
                {
                    b.HasOne("YellowBucket1.Models.Customers", "Customer")
                        .WithMany("CustomerReviews")
                        .HasForeignKey("CustomersID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YellowBucket1.Models.Movies", null)
                        .WithMany("CustomerReviews")
                        .HasForeignKey("MoviesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("YellowBucket1.Models.Inventories", b =>
                {
                    b.HasOne("YellowBucket1.Models.Movies", null)
                        .WithMany("Inventories")
                        .HasForeignKey("MoviesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("YellowBucket1.Models.MoviesGenres", b =>
                {
                    b.HasOne("YellowBucket1.Models.Genres", "Genres")
                        .WithMany("MoviesGenres")
                        .HasForeignKey("GenresID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YellowBucket1.Models.Movies", "Movies")
                        .WithMany("MoviesGenres")
                        .HasForeignKey("MoviesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("YellowBucket1.Models.Passwords", b =>
                {
                    b.HasOne("YellowBucket1.Models.Customers", "Customers")
                        .WithMany("Passwords")
                        .HasForeignKey("CustomersID");
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
                    b.HasOne("YellowBucket1.Models.Customers", null)
                        .WithMany("Wishlists")
                        .HasForeignKey("CustomersID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YellowBucket1.Models.Movies", null)
                        .WithMany("Wishlists")
                        .HasForeignKey("MoviesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
