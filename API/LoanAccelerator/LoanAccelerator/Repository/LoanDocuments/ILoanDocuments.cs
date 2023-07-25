using LoanAccelerator.Models;
using Microsoft.AspNetCore.Mvc;

namespace LoanAccelerator.Repository.LoanDocuments
{
    public interface ILoanDocuments
    {
        Task<List<LoanDocumentsTable>> GetLoanDocumentsTables();
        Task<List<LoanDocumentsTable>> GetLoanDocumentsTable(int id);
        Task<List<LoanDocumentsTable>> PutLoanDocumentsTable(int id, LoanDocumentsTable loanDocumentsTable);
        Task<List<LoanDocumentsTable>> PostLoanDocumentsTable(LoanDocumentsTable loanDocumentsTable);
        Task<List<LoanDocumentsTable>> DeleteLoanDocumentsTable(int id);

    }
}
