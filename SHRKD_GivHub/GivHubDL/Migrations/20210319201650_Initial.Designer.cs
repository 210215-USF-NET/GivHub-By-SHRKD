﻿// <auto-generated />
using System;
using GivHubDL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace GivHubDL.Migrations
{
    [DbContext(typeof(GHDBContext))]
    [Migration("20210319201650_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("GivHubModels.Charity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Category")
                        .HasColumnType("text");

                    b.Property<int?>("Location_idId")
                        .HasColumnType("integer");

                    b.Property<string>("Logourl")
                        .HasColumnType("text");

                    b.Property<string>("Missionstatement")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Website")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Location_idId");

                    b.ToTable("Charities");
                });

            modelBuilder.Entity("GivHubModels.Donation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("numeric");

                    b.Property<int?>("Charity_idId")
                        .HasColumnType("integer");

                    b.Property<string>("User_idId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Charity_idId");

                    b.HasIndex("User_idId");

                    b.ToTable("Donations");
                });

            modelBuilder.Entity("GivHubModels.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<string>("State")
                        .HasColumnType("text");

                    b.Property<string>("Zipcode")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("GivHubModels.SearchHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Phrase")
                        .HasColumnType("text");

                    b.Property<string>("User_idId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("User_idId");

                    b.ToTable("SearchHistories");
                });

            modelBuilder.Entity("GivHubModels.Subscription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("Charity_idId")
                        .HasColumnType("integer");

                    b.Property<string>("User_idId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Charity_idId");

                    b.HasIndex("User_idId");

                    b.ToTable("Subscriptions");
                });

            modelBuilder.Entity("GivHubModels.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("FirstName")
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("IsManager")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("text");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("GivHubModels.Charity", b =>
                {
                    b.HasOne("GivHubModels.Location", "Location_id")
                        .WithMany()
                        .HasForeignKey("Location_idId");

                    b.Navigation("Location_id");
                });

            modelBuilder.Entity("GivHubModels.Donation", b =>
                {
                    b.HasOne("GivHubModels.Charity", "Charity_id")
                        .WithMany()
                        .HasForeignKey("Charity_idId");

                    b.HasOne("GivHubModels.User", "User_id")
                        .WithMany()
                        .HasForeignKey("User_idId");

                    b.Navigation("Charity_id");

                    b.Navigation("User_id");
                });

            modelBuilder.Entity("GivHubModels.SearchHistory", b =>
                {
                    b.HasOne("GivHubModels.User", "User_id")
                        .WithMany()
                        .HasForeignKey("User_idId");

                    b.Navigation("User_id");
                });

            modelBuilder.Entity("GivHubModels.Subscription", b =>
                {
                    b.HasOne("GivHubModels.Charity", "Charity_id")
                        .WithMany()
                        .HasForeignKey("Charity_idId");

                    b.HasOne("GivHubModels.User", "User_id")
                        .WithMany()
                        .HasForeignKey("User_idId");

                    b.Navigation("Charity_id");

                    b.Navigation("User_id");
                });
#pragma warning restore 612, 618
        }
    }
}
