using Database.Context;
using Database.Model;

namespace Business.Services
{
    public class AdminService
    {
        private readonly BankDbContext _context;

        public AdminService(BankDbContext context)
        {
            _context = context;
        }

        public List<Admin> GetAllAdmins()
        {
            return _context.Admins.ToList();
        }

        public Admin GetAdminById(int id)
        {
            return _context.Admins.Find(id);
        }

        public void AddAdmin(Admin admin)
        {
            _context.Admins.Add(admin);
            _context.SaveChanges();
        }

        public void RemoveAdmin(int id)
        {
            var admin = _context.Admins.Find(id);
            if (admin != null)
            {
                _context.Admins.Remove(admin);
                _context.SaveChanges();
            }
        }
    }
}
