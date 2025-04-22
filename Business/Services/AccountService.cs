using Database.Context;
using Database.Model;

namespace Business.Services
{
    public class AccountService
    {
        private readonly BankDbContext _context;

        public AccountService(BankDbContext context)
        {
            _context = context;
        }

        public List<Account> GetAllAccounts()
        {
            return _context.Accounts.ToList();
        }

        public Account GetAccountById(int id)
        {
            return _context.Accounts.Find(id);
        }

        public void CreateAccount(Account account)
        {
            _context.Accounts.Add(account);
            _context.SaveChanges();
        }

        public void UpdateAccount(Account account)
        {
            _context.Accounts.Update(account);
            _context.SaveChanges();
        }

        public void DeleteAccount(int id)
        {
            var account = _context.Accounts.Find(id);
            if (account != null)
            {
                _context.Accounts.Remove(account);
                _context.SaveChanges();
            }
        }
    }
}
