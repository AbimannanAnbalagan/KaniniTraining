﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SampOnetoManyAPI.Models;

#nullable disable

namespace SampOnetoManyAPI.Migrations
{
    [DbContext(typeof(ProCatContext))]
    partial class ProCatContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MovieTicketBooking.Models.MovieDetails", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MovieId"));

                    b.Property<float>("Cost")
                        .HasColumnType("real");

                    b.Property<string>("DroppedDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MovieGenre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MovieTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReleasedDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("screening_scheduleScreenId")
                        .HasColumnType("int");

                    b.HasKey("MovieId");

                    b.HasIndex("screening_scheduleScreenId");

                    b.ToTable("MoviesDetails");
                });

            modelBuilder.Entity("MovieTicketBooking.Models.Seat", b =>
                {
                    b.Property<string>("SeatId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ScreenId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SeatId");

                    b.ToTable("Seats");
                });

            modelBuilder.Entity("MovieTicketBooking.Models.TicketBookings", b =>
                {
                    b.Property<int>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingId"));

                    b.Property<float>("Cash")
                        .HasColumnType("real");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<int?>("MovieDetailsMovieId")
                        .HasColumnType("int");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("ScreenId")
                        .HasColumnType("int");

                    b.Property<string>("SeatId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int?>("UsersUserId")
                        .HasColumnType("int");

                    b.Property<int?>("screening_scheduleScreenId")
                        .HasColumnType("int");

                    b.HasKey("BookingId");

                    b.HasIndex("MovieDetailsMovieId");

                    b.HasIndex("SeatId");

                    b.HasIndex("UsersUserId");

                    b.HasIndex("screening_scheduleScreenId");

                    b.ToTable("ticketBookings");
                });

            modelBuilder.Entity("MovieTicketBooking.Models.Users", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("EmailId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MovieTicketBooking.Models.screening_schedule", b =>
                {
                    b.Property<int>("ScreenId")
                        .HasColumnType("int");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<string>("ScreenTimings")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ScreenId");

                    b.HasIndex("MovieId");

                    b.ToTable("ScreeningSchedules");
                });

            modelBuilder.Entity("SampOnetoManyAPI.Models.Product", b =>
                {
                    b.Property<int>("ProId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProId"));

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("ProName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("SampOnetoManyAPI.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Roles")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("MovieTicketBooking.Models.MovieDetails", b =>
                {
                    b.HasOne("MovieTicketBooking.Models.screening_schedule", null)
                        .WithMany("SmovieDetails")
                        .HasForeignKey("screening_scheduleScreenId");
                });

            modelBuilder.Entity("MovieTicketBooking.Models.TicketBookings", b =>
                {
                    b.HasOne("MovieTicketBooking.Models.MovieDetails", null)
                        .WithMany("MticketBookings")
                        .HasForeignKey("MovieDetailsMovieId");

                    b.HasOne("MovieTicketBooking.Models.Seat", null)
                        .WithMany("SEATticketBookings")
                        .HasForeignKey("SeatId");

                    b.HasOne("MovieTicketBooking.Models.Users", null)
                        .WithMany("UticketBookings")
                        .HasForeignKey("UsersUserId");

                    b.HasOne("MovieTicketBooking.Models.screening_schedule", null)
                        .WithMany("SticketBookings")
                        .HasForeignKey("screening_scheduleScreenId");
                });

            modelBuilder.Entity("MovieTicketBooking.Models.screening_schedule", b =>
                {
                    b.HasOne("MovieTicketBooking.Models.MovieDetails", "MovieDetails")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MovieDetails");
                });

            modelBuilder.Entity("MovieTicketBooking.Models.MovieDetails", b =>
                {
                    b.Navigation("MticketBookings");
                });

            modelBuilder.Entity("MovieTicketBooking.Models.Seat", b =>
                {
                    b.Navigation("SEATticketBookings");
                });

            modelBuilder.Entity("MovieTicketBooking.Models.Users", b =>
                {
                    b.Navigation("UticketBookings");
                });

            modelBuilder.Entity("MovieTicketBooking.Models.screening_schedule", b =>
                {
                    b.Navigation("SmovieDetails");

                    b.Navigation("SticketBookings");
                });
#pragma warning restore 612, 618
        }
    }
}