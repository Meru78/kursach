using Microsoft.AspNetCore.Mvc;
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

        public User? GetUserByLoginPass(string login, string passHash)
        {
            User? user = _context.Users.Where(row => row.Login == login && row.PasswordHash == passHash).FirstOrDefault();
            return user;
        }

        public void CreateUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
    }
}
