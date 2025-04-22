using Database.Context;
using Database.Model;

namespace Business.Services
{
    public class TransactionService
    {
        private readonly BankDbContext _context;

        public TransactionService(BankDbContext context)
        {
            _context = context;
        }

        public List<Transaction> GetAllTransactions()
        {
            return _context.Transactions.ToList();
        }

        public Transaction GetTransactionById(int id)
        {
            return _context.Transactions.Find(id);
        }

        public void CreateTransaction(Transaction transaction)
        {
            _context.Transactions.Add(transaction);

            // Optional: update account balance logic here
            var account = _context.Accounts.Find(transaction.AccountID);
            if (account != null)
            {
                switch (transaction.TransactionType.ToLower())
                {
                    case "deposit":
                        account.Balance += transaction.Amount;
                        break;
                    case "withdrawal":
                        account.Balance -= transaction.Amount;
                        break;
                }
                _context.SaveChanges();
            }
        }
    }
}
