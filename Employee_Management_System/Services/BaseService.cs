using Employee_Management_System.Data;

namespace Employee_Management_System.Services
{
    public abstract class BaseService
    {
        protected readonly AppDbContext _context;

        protected BaseService(AppDbContext context)
        {
            _context = context;
        }
    }
}
