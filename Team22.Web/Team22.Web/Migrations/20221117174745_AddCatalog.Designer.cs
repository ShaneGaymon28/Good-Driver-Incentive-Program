﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Team22.Web.Contexts;

#nullable disable

namespace Team22.Web.Migrations
{
    [DbContext(typeof(Team22Context))]
    [Migration("20221117174745_AddCatalog")]
    partial class AddCatalog
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Team22.Web.Models.Application", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Reason")
                        .HasColumnType("longtext");

                    b.Property<int>("SponsorId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SponsorId");

                    b.HasIndex("UserId");

                    b.ToTable("Application");
                });

            modelBuilder.Entity("Team22.Web.Models.Audit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AuditExtra")
                        .HasColumnType("longtext");

                    b.Property<int>("AuditType")
                        .HasColumnType("int");

                    b.Property<int?>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Audits");
                });

            modelBuilder.Entity("Team22.Web.Models.Catalog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("SponsorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SponsorId");

                    b.ToTable("Catalog");
                });

            modelBuilder.Entity("Team22.Web.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("OrderStatus")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Team22.Web.Models.PasswordChange", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Expiration")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Forced")
                        .HasColumnType("tinyint(1)");

                    b.Property<Guid>("Secret")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.ToTable("PasswordChanges");
                });

            modelBuilder.Entity("Team22.Web.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("ArtistId")
                        .HasColumnType("int");

                    b.Property<string>("ArtistName")
                        .HasColumnType("longtext");

                    b.Property<string>("ArtworkURL")
                        .HasColumnType("longtext");

                    b.Property<int>("CatalogId")
                        .HasColumnType("int");

                    b.Property<int?>("CollectionId")
                        .HasColumnType("int");

                    b.Property<string>("CollectionName")
                        .HasColumnType("longtext");

                    b.Property<double>("DollarPrice")
                        .HasColumnType("double");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<double>("PointPrice")
                        .HasColumnType("double");

                    b.Property<int?>("TrackId")
                        .HasColumnType("int");

                    b.Property<string>("TrackName")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("CatalogId");

                    b.HasIndex("OrderId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Team22.Web.Models.Sponsor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<double>("PointDollarRatio")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Sponsors");
                });

            modelBuilder.Entity("Team22.Web.Models.SponsorUserBridge", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Points")
                        .HasColumnType("int");

                    b.Property<int>("SponsorId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SponsorId");

                    b.HasIndex("UserId");

                    b.ToTable("Bridges");
                });

            modelBuilder.Entity("Team22.Web.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("PasswordChangeId")
                        .HasColumnType("int");

                    b.Property<int>("UserRole")
                        .HasColumnType("int");

                    b.Property<int>("VerificationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("PasswordChangeId");

                    b.HasIndex("VerificationId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Team22.Web.Models.Verification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("Secret")
                        .HasColumnType("char(36)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Verification");
                });

            modelBuilder.Entity("Team22.Web.Models.Application", b =>
                {
                    b.HasOne("Team22.Web.Models.Sponsor", "Sponsor")
                        .WithMany()
                        .HasForeignKey("SponsorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Team22.Web.Models.User", "User")
                        .WithMany("Applications")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sponsor");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Team22.Web.Models.Audit", b =>
                {
                    b.HasOne("Team22.Web.Models.User", "Author")
                        .WithMany("AuthorEntries")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("Team22.Web.Models.User", "Subject")
                        .WithMany("SubjectEntries")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("Team22.Web.Models.Catalog", b =>
                {
                    b.HasOne("Team22.Web.Models.Sponsor", "Sponsor")
                        .WithMany()
                        .HasForeignKey("SponsorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sponsor");
                });

            modelBuilder.Entity("Team22.Web.Models.Order", b =>
                {
                    b.HasOne("Team22.Web.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Team22.Web.Models.Product", b =>
                {
                    b.HasOne("Team22.Web.Models.Catalog", "Catalog")
                        .WithMany("Products")
                        .HasForeignKey("CatalogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Team22.Web.Models.Order", "Order")
                        .WithMany("Products")
                        .HasForeignKey("OrderId");

                    b.Navigation("Catalog");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Team22.Web.Models.SponsorUserBridge", b =>
                {
                    b.HasOne("Team22.Web.Models.Sponsor", "Sponsor")
                        .WithMany("Users")
                        .HasForeignKey("SponsorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Team22.Web.Models.User", "User")
                        .WithMany("Sponsors")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sponsor");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Team22.Web.Models.User", b =>
                {
                    b.HasOne("Team22.Web.Models.PasswordChange", "PasswordChange")
                        .WithMany()
                        .HasForeignKey("PasswordChangeId");

                    b.HasOne("Team22.Web.Models.Verification", "Verification")
                        .WithMany()
                        .HasForeignKey("VerificationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PasswordChange");

                    b.Navigation("Verification");
                });

            modelBuilder.Entity("Team22.Web.Models.Catalog", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Team22.Web.Models.Order", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Team22.Web.Models.Sponsor", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Team22.Web.Models.User", b =>
                {
                    b.Navigation("Applications");

                    b.Navigation("AuthorEntries");

                    b.Navigation("Orders");

                    b.Navigation("Sponsors");

                    b.Navigation("SubjectEntries");
                });
#pragma warning restore 612, 618
        }
    }
}