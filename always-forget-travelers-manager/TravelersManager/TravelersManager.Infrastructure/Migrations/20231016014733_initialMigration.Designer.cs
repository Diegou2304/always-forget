﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelersManager.Infrastructure;

#nullable disable

namespace TravelersManager.Infrastructure.Migrations
{
    [DbContext(typeof(TravelersManagerDbContext))]
    [Migration("20231016014733_initialMigration")]
    partial class initialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TravelersManager.Domain.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AddressId"));

                    b.Property<string>("Direction")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AddressId");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("TravelersManager.Domain.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<int>("CategoryIdentifier")
                        .HasColumnType("int");

                    b.Property<int>("TravelerId")
                        .HasColumnType("int");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("TravelersManager.Domain.JoinEntities.TravelerAddress", b =>
                {
                    b.Property<int>("AddressesAddressId")
                        .HasColumnType("int");

                    b.Property<int>("TravelerId")
                        .HasColumnType("int");

                    b.Property<int>("AdressId")
                        .HasColumnType("int");

                    b.HasKey("AddressesAddressId", "TravelerId");

                    b.HasIndex("TravelerId");

                    b.ToTable("TravelerAddress");
                });

            modelBuilder.Entity("TravelersManager.Domain.JoinEntities.TravelerNumbers", b =>
                {
                    b.Property<int>("PhoneNumberId")
                        .HasColumnType("int");

                    b.Property<int>("TravelerId")
                        .HasColumnType("int");

                    b.HasKey("PhoneNumberId", "TravelerId");

                    b.HasIndex("TravelerId");

                    b.ToTable("TravelerNumbers");
                });

            modelBuilder.Entity("TravelersManager.Domain.PhoneNumber", b =>
                {
                    b.Property<int>("PhoneNumberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PhoneNumberId"));

                    b.HasKey("PhoneNumberId");

                    b.ToTable("PhoneNumbers");
                });

            modelBuilder.Entity("TravelersManager.Domain.Traveler", b =>
                {
                    b.Property<int>("TravelerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TravelerId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("CivilState")
                        .HasColumnType("int");

                    b.Property<string>("Dni")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TravelerId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Travelers");
                });

            modelBuilder.Entity("TravelersManager.Domain.JoinEntities.TravelerAddress", b =>
                {
                    b.HasOne("TravelersManager.Domain.Address", null)
                        .WithMany("TravelerAddresses")
                        .HasForeignKey("AddressesAddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TravelersManager.Domain.Traveler", null)
                        .WithMany("TravelerAddresses")
                        .HasForeignKey("TravelerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TravelersManager.Domain.JoinEntities.TravelerNumbers", b =>
                {
                    b.HasOne("TravelersManager.Domain.PhoneNumber", "PhoneNumber")
                        .WithMany("TravelerNumbers")
                        .HasForeignKey("PhoneNumberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TravelersManager.Domain.Traveler", "Traveler")
                        .WithMany("TravelerNumbers")
                        .HasForeignKey("TravelerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PhoneNumber");

                    b.Navigation("Traveler");
                });

            modelBuilder.Entity("TravelersManager.Domain.Traveler", b =>
                {
                    b.HasOne("TravelersManager.Domain.Category", "Category")
                        .WithMany("Travelers")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("TravelersManager.Domain.Address", b =>
                {
                    b.Navigation("TravelerAddresses");
                });

            modelBuilder.Entity("TravelersManager.Domain.Category", b =>
                {
                    b.Navigation("Travelers");
                });

            modelBuilder.Entity("TravelersManager.Domain.PhoneNumber", b =>
                {
                    b.Navigation("TravelerNumbers");
                });

            modelBuilder.Entity("TravelersManager.Domain.Traveler", b =>
                {
                    b.Navigation("TravelerAddresses");

                    b.Navigation("TravelerNumbers");
                });
#pragma warning restore 612, 618
        }
    }
}
