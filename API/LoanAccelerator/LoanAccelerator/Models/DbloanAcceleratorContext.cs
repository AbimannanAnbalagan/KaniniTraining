using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LoanAccelerator.Models;

public partial class DbloanAcceleratorContext : DbContext
{
    public DbloanAcceleratorContext()
    {
    }

    public DbloanAcceleratorContext(DbContextOptions<DbloanAcceleratorContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AddressInformationTable> AddressInformationTables { get; set; }

    public virtual DbSet<Customertable> Customertables { get; set; }

    public virtual DbSet<EmergencyContactDetail> EmergencyContactDetails { get; set; }

    public virtual DbSet<EmployementTable> EmployementTables { get; set; }

    public virtual DbSet<FamilyDetail> FamilyDetails { get; set; }

    public virtual DbSet<FinancialInformationTable> FinancialInformationTables { get; set; }

    public virtual DbSet<LoanDocumentsTable> LoanDocumentsTables { get; set; }

    public virtual DbSet<LoanTable> LoanTables { get; set; }

    public virtual DbSet<PersonalInformationTable> PersonalInformationTables { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("data source = .\\SQLEXPRESS; initial catalog =DBLoanAccelerator; integrated security=SSPI;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AddressInformationTable>(entity =>
        {
            entity.HasKey(e => e.AddressInformationId).HasName("PK__AddressI__E0EBE5A4FB7057F9");

            entity.ToTable("AddressInformationTable");

            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.District).HasMaxLength(50);
            entity.Property(e => e.EmailId).HasMaxLength(50);
            entity.Property(e => e.PermanantAddress).HasMaxLength(100);
            entity.Property(e => e.PresentAddress).HasMaxLength(100);

            entity.HasOne(d => d.Loan).WithMany(p => p.AddressInformationTables)
                .HasForeignKey(d => d.LoanId)
                .HasConstraintName("FK__AddressIn__LoanI__5441852A");
        });

        modelBuilder.Entity<Customertable>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__CUSTOMER__A4AE64D8F5EDF6DA");

            entity.ToTable("CUSTOMERTABLE");

            entity.Property(e => e.EmailId).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(20);
        });

        modelBuilder.Entity<EmergencyContactDetail>(entity =>
        {
            entity.HasKey(e => e.EmergencyContactId).HasName("PK__Emergenc__E8A61D8E7E8DBB9B");

            entity.Property(e => e.Address).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(59);
            entity.Property(e => e.Relation).HasMaxLength(25);

            entity.HasOne(d => d.Loan).WithMany(p => p.EmergencyContactDetails)
                .HasForeignKey(d => d.LoanId)
                .HasConstraintName("FK__Emergency__LoanI__59FA5E80");
        });

        modelBuilder.Entity<EmployementTable>(entity =>
        {
            entity.HasKey(e => e.EmploymentId).HasName("PK__Employem__FDC872B6EC2300ED");

            entity.ToTable("EmployementTable");

            entity.Property(e => e.CompanyName).HasMaxLength(50);
            entity.Property(e => e.Designation).HasMaxLength(30);
            entity.Property(e => e.EmailId).HasMaxLength(50);
            entity.Property(e => e.EmployeeStatus).HasMaxLength(30);
            entity.Property(e => e.EmploymentType).HasMaxLength(9);
            entity.Property(e => e.OfficeAddress).HasMaxLength(100);

            entity.HasOne(d => d.Loan).WithMany(p => p.EmployementTables)
                .HasForeignKey(d => d.LoanId)
                .HasConstraintName("FK__Employeme__LoanI__5CD6CB2B");
        });

        modelBuilder.Entity<FamilyDetail>(entity =>
        {
            entity.HasKey(e => e.FamilyDetailsId).HasName("PK__FamilyDe__41067C25C338BECA");

            entity.Property(e => e.EmailId).HasMaxLength(50);
            entity.Property(e => e.JointAccount).HasMaxLength(5);
            entity.Property(e => e.NameOfOrganisation).HasMaxLength(50);
            entity.Property(e => e.Profession).HasMaxLength(25);
            entity.Property(e => e.SpouseName).HasMaxLength(25);

            entity.HasOne(d => d.Loan).WithMany(p => p.FamilyDetails)
                .HasForeignKey(d => d.LoanId)
                .HasConstraintName("FK__FamilyDet__LoanI__571DF1D5");
        });

        modelBuilder.Entity<FinancialInformationTable>(entity =>
        {
            entity.HasKey(e => e.FinancialInformationId).HasName("PK__Financia__713EF85145B183BA");

            entity.ToTable("FinancialInformationTable");

            entity.Property(e => e.FinancialInformationId).HasColumnName("FinancialInformationID");
            entity.Property(e => e.Cfwob)
                .HasMaxLength(5)
                .HasColumnName("CFWOB");
            entity.Property(e => e.Dwob)
                .HasMaxLength(5)
                .HasColumnName("DWOB");
            entity.Property(e => e.Education).HasColumnType("money");
            entity.Property(e => e.FoodAndClothing).HasColumnType("money");
            entity.Property(e => e.IncomeRent).HasColumnType("money");
            entity.Property(e => e.IncomeSalary).HasColumnType("money");
            entity.Property(e => e.InterstRate).HasColumnType("money");
            entity.Property(e => e.LoanRepayment)
                .HasColumnType("money")
                .HasColumnName("LoanREpayment");
            entity.Property(e => e.OtherExpenses).HasColumnType("money");
            entity.Property(e => e.OtherIncome).HasColumnType("money");
            entity.Property(e => e.RentAndUtility).HasColumnType("money");

            entity.HasOne(d => d.Loan).WithMany(p => p.FinancialInformationTables)
                .HasForeignKey(d => d.LoanId)
                .HasConstraintName("FK__Financial__LoanI__5FB337D6");
        });

        modelBuilder.Entity<LoanDocumentsTable>(entity =>
        {
            entity.HasKey(e => e.LoanDocuments).HasName("PK__LoanDocu__D50F95AF5C89B2D9");

            entity.ToTable("LoanDocumentsTable");

            entity.Property(e => e.IdProof).HasMaxLength(100);
            entity.Property(e => e.PassportSizePhoto).HasMaxLength(100);
            entity.Property(e => e.SignaturePhoto).HasMaxLength(100);

            entity.HasOne(d => d.Loan).WithMany(p => p.LoanDocumentsTables)
                .HasForeignKey(d => d.LoanId)
                .HasConstraintName("FK__LoanDocum__IdPro__4E88ABD4");
        });

        modelBuilder.Entity<LoanTable>(entity =>
        {
            entity.HasKey(e => e.LoanId).HasName("PK__LoanTABL__4F5AD457E63988E4");

            entity.ToTable("LoanTABLE");

            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.Date).HasColumnType("date");
            entity.Property(e => e.ExpectedExpenditure).HasColumnType("money");
            entity.Property(e => e.PurposeOfLoan).HasMaxLength(50);
            entity.Property(e => e.Tenure).HasMaxLength(10);

            entity.HasOne(d => d.Customer).WithMany(p => p.LoanTables)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK__LoanTABLE__Custo__4BAC3F29");
        });

        modelBuilder.Entity<PersonalInformationTable>(entity =>
        {
            entity.HasKey(e => e.PersonalInformationId).HasName("PK__Personal__09730AF8E81F8BF8");

            entity.ToTable("PersonalInformationTable");

            entity.Property(e => e.CountryOfInsurance).HasMaxLength(50);
            entity.Property(e => e.CoutryOfBirth).HasMaxLength(50);
            entity.Property(e => e.DateOfInsurance).HasColumnType("date");
            entity.Property(e => e.DistrictofBirth).HasMaxLength(50);
            entity.Property(e => e.Dob)
                .HasColumnType("date")
                .HasColumnName("DOB");
            entity.Property(e => e.EducationQualification).HasMaxLength(50);
            entity.Property(e => e.FathersName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fullname).HasMaxLength(50);
            entity.Property(e => e.Gender).HasMaxLength(11);
            entity.Property(e => e.IsExistingCustomer).HasMaxLength(5);
            entity.Property(e => e.MaritalStatus).HasMaxLength(9);
            entity.Property(e => e.MothersName).HasMaxLength(50);
            entity.Property(e => e.NationalId).HasMaxLength(50);
            entity.Property(e => e.Nationality).HasMaxLength(50);
            entity.Property(e => e.ResidentialStatus).HasMaxLength(50);

            entity.HasOne(d => d.Loan).WithMany(p => p.PersonalInformationTables)
                .HasForeignKey(d => d.LoanId)
                .HasConstraintName("FK__PersonalI__LoanI__5165187F");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
