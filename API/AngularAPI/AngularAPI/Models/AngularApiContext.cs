using System;
using System.Collections.Generic;
using AngularAPI.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AngularAPI.Models;

public partial class AngularApiContext : DbContext
{
    public AngularApiContext()
    {
    }

    public AngularApiContext(DbContextOptions<AngularApiContext> options)
        : base(options)
    {
    }

    public DbSet<TokenInfo> TokenInfo { get; set; }

    public virtual DbSet<Booking> Bookings { get; set; }

    public virtual DbSet<Hotel> Hotels { get; set; }

    public virtual DbSet<Room> Rooms { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserFeedback> UserFeedbacks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("data source = .\\SQLEXPRESS; initial catalog = AngularAPI; integrated security=SSPI;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Booking>(entity =>
        {
            entity.HasKey(e => e.BookingId).HasName("PK__Booking__73951AED77505BAE");

            entity.ToTable("Booking");

            entity.Property(e => e.CheckIn).HasColumnType("date");
            entity.Property(e => e.CheckOut).HasColumnType("date");
            entity.Property(e => e.Price).HasColumnType("money");

            entity.HasOne(d => d.Hotel).WithMany(p => p.Bookings)
                .HasForeignKey(d => d.HotelId)
                .HasConstraintName("FK__Booking__CheckOu__403A8C7D");

            entity.HasOne(d => d.Room).WithMany(p => p.Bookings)
                .HasForeignKey(d => d.RoomId)
                .HasConstraintName("FK__Booking__RoomId__412EB0B6");
        });

        modelBuilder.Entity<Hotel>(entity =>
        {
            entity.HasKey(e => e.HotelId).HasName("PK__Hotels__46023BDF0B0B98A7");

            entity.Property(e => e.HotelName).HasMaxLength(30);
            entity.Property(e => e.Location).HasMaxLength(100);
        });

        modelBuilder.Entity<Room>(entity =>
        {
            entity.HasKey(e => e.RoomId).HasName("PK__Rooms__328639395B204554");

            entity.Property(e => e.AvailabilityStatus).HasMaxLength(9);
            entity.Property(e => e.Cost).HasColumnType("money");
            entity.Property(e => e.Type).HasMaxLength(10);

            entity.HasOne(d => d.Hotel).WithMany(p => p.Rooms)
                .HasForeignKey(d => d.HotelId)
                .HasConstraintName("FK__Rooms__Cost__3C69FB99");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__1788CC4CABA1BACD");

            entity.HasIndex(e => e.MobileNumber, "UQ__Users__250375B1E17093F7").IsUnique();

            entity.Property(e => e.Password).HasMaxLength(15);
            entity.Property(e => e.Roles).HasMaxLength(8);
            entity.Property(e => e.UserName).HasMaxLength(30);
        });

        modelBuilder.Entity<UserFeedback>(entity =>
        {
            entity.HasKey(e => e.FeedbackId).HasName("PK__UserFeed__6A4BEDD6EF4F822A");

            entity.ToTable("UserFeedback");

            entity.Property(e => e.Feedback).HasMaxLength(300);

            entity.HasOne(d => d.User).WithMany(p => p.UserFeedbacks)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__UserFeedb__Feedb__440B1D61");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    //internal Task<ActionResult<IEnumerable<User>>> GetUsers()
    //{
      //  throw new NotImplementedException();
    //}

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
