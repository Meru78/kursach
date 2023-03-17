using Microsoft.EntityFrameworkCore;

namespace kursach.DBManager.Models.UserModels
{
    public class UserController
    {
        public UserController(DBManager context)
        {
            _context = context;
        }

        DBManager _context;

        public async Task<User[]> GetUsers()
        {
            return await _context.Users.ToArrayAsync();
        }
    }
}
