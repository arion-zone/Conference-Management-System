﻿// <auto-generated />
using System;
using ConferenceManagementSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ConferenceManagementSystem.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250206225341_ResetDatabase")]
    partial class ResetDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.1");

            modelBuilder.Entity("AttendeeConference", b =>
                {
                    b.Property<int>("AttendeesId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ConferencesId")
                        .HasColumnType("INTEGER");

                    b.HasKey("AttendeesId", "ConferencesId");

                    b.HasIndex("ConferencesId");

                    b.ToTable("AttendeeConference");
                });

            modelBuilder.Entity("ConferenceManagementSystem.Models.Attendee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Attendees");
                });

            modelBuilder.Entity("ConferenceManagementSystem.Models.Conference", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Conferences");
                });

            modelBuilder.Entity("ConferenceManagementSystem.Models.Organizer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Organizers");
                });

            modelBuilder.Entity("ConferenceManagementSystem.Models.Registration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AttendeeId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ConferenceId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AttendeeId");

                    b.HasIndex("ConferenceId");

                    b.ToTable("Registrations");
                });

            modelBuilder.Entity("ConferenceOrganizer", b =>
                {
                    b.Property<int>("ConferencesId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("OrganizersId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ConferencesId", "OrganizersId");

                    b.HasIndex("OrganizersId");

                    b.ToTable("ConferenceOrganizer");
                });

            modelBuilder.Entity("AttendeeConference", b =>
                {
                    b.HasOne("ConferenceManagementSystem.Models.Attendee", null)
                        .WithMany()
                        .HasForeignKey("AttendeesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConferenceManagementSystem.Models.Conference", null)
                        .WithMany()
                        .HasForeignKey("ConferencesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ConferenceManagementSystem.Models.Registration", b =>
                {
                    b.HasOne("ConferenceManagementSystem.Models.Attendee", "Attendee")
                        .WithMany()
                        .HasForeignKey("AttendeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConferenceManagementSystem.Models.Conference", "Conference")
                        .WithMany()
                        .HasForeignKey("ConferenceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Attendee");

                    b.Navigation("Conference");
                });

            modelBuilder.Entity("ConferenceOrganizer", b =>
                {
                    b.HasOne("ConferenceManagementSystem.Models.Conference", null)
                        .WithMany()
                        .HasForeignKey("ConferencesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConferenceManagementSystem.Models.Organizer", null)
                        .WithMany()
                        .HasForeignKey("OrganizersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
