using Database.Context;
using Database.Model;

namespace Business.Services
{
    public class LoanService
    {
        private readonly BankDbContext _context;

        public LoanService(BankDbContext context)
        {
            _context = context;
        }

        public List<Loan> GetAllLoans()
        {
            return _context.Loans.ToList();
        }

        public Loan GetLoanById(int id)
        {
            return _context.Loans.Find(id);
        }

        public void ApplyForLoan(Loan loan)
        {
            _context.Loans.Add(loan);
            _context.SaveChanges();
        }

        public void ApproveLoan(int id)
        {
            var loan = _context.Loans.Find(id);
            if (loan != null)
            {
                loan.Status = "Approved";
                _context.SaveChanges();
            }
        }

        public void RejectLoan(int id)
        {
            var loan = _context.Loans.Find(id);
            if (loan != null)
            {
                loan.Status = "Rejected";
                _context.SaveChanges();
            }
        }
    }
}
