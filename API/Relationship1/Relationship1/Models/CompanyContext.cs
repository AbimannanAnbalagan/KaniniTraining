using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Relationship1.Models;

public partial class CompanyContext : DbContext
{
    public CompanyContext()
    {
    }

    public CompanyContext(DbContextOptions<CompanyContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Emp> Emps { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.DeptNo).HasName("PK__DEPARTME__512A302CA2E8EA04");

            entity.ToTable("DEPARTMENT");

            entity.Property(e => e.DeptNo)
                .ValueGeneratedNever()
                .HasColumnName("DEPT_NO");
            entity.Property(e => e.DeptName)
                .HasMaxLength(20)
                .HasColumnName("DEPT_NAME");
        });

        modelBuilder.Entity<Emp>(entity =>
        {
            entity.HasKey(e => e.Empno).HasName("PK__EMP__14CCF2EEDAA50ADC");

            entity.ToTable("EMP");

            entity.Property(e => e.Empno)
                .ValueGeneratedNever()
                .HasColumnName("EMPNO");
            entity.Property(e => e.DepNo).HasColumnName("DEP_NO");
            entity.Property(e => e.EmpName)
                .HasMaxLength(30)
                .HasColumnName("EMP_NAME");

            entity.HasOne(d => d.DepNoNavigation).WithMany(p => p.Emps)
                .HasForeignKey(d => d.DepNo)
                .HasConstraintName("FK__EMP__DEP_NO__398D8EEE");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
