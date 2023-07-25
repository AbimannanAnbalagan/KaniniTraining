using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Nandha.Models;

public partial class SystemContext : DbContext
{
    public SystemContext()
    {
    }

    public SystemContext(DbContextOptions<SystemContext> options)
        : base(options)
    {
    }

    public virtual DbSet<StudDetail> StudDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("data source = .\\SQLEXPRESS; initial catalog = system; integrated security=SSPI;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<StudDetail>(entity =>
        {
            entity.HasKey(e => e.Rno).HasName("PK__stud_det__C2B7F59B6AFFDA3C");

            entity.ToTable("stud_details");

            entity.Property(e => e.Rno)
                .ValueGeneratedNever()
                .HasColumnName("rno");
            entity.Property(e => e.Name)
                .HasMaxLength(25)
                .HasColumnName("name");
            entity.Property(e => e.PhoneNum).HasColumnName("phone_num");
            entity.Property(e => e.Section).HasColumnName("section");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
