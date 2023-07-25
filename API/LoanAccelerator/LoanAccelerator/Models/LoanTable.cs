using System;
using System.Collections.Generic;

namespace LoanAccelerator.Models;

public partial class LoanTable
{
    public int LoanId { get; set; }

    public int? CustomerId { get; set; }

    public decimal? Amount { get; set; }

    public string? Tenure { get; set; }

    public DateTime? Date { get; set; }

    public int? Status { get; set; }

    public int? LoanCategory { get; set; }

    public decimal? ExpectedExpenditure { get; set; }

    public string? PurposeOfLoan { get; set; }

    public int? LoanType { get; set; }

    public virtual ICollection<AddressInformationTable> AddressInformationTables { get; set; } = new List<AddressInformationTable>();

    public virtual Customertable? Customer { get; set; }

    public virtual ICollection<EmergencyContactDetail> EmergencyContactDetails { get; set; } = new List<EmergencyContactDetail>();

    public virtual ICollection<EmployementTable> EmployementTables { get; set; } = new List<EmployementTable>();

    public virtual ICollection<FamilyDetail> FamilyDetails { get; set; } = new List<FamilyDetail>();

    public virtual ICollection<FinancialInformationTable> FinancialInformationTables { get; set; } = new List<FinancialInformationTable>();

    public virtual ICollection<LoanDocumentsTable> LoanDocumentsTables { get; set; } = new List<LoanDocumentsTable>();

    public virtual ICollection<PersonalInformationTable> PersonalInformationTables { get; set; } = new List<PersonalInformationTable>();
}
