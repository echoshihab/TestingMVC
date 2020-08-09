using System.Collections.Generic;
using System.Linq;
using TestingAspNetCoreMVC.Web.Data.Repository.IRepository;
using TestingAspNetCoreMVC.Web.Models;

namespace TestingAspNetCoreMVC.Web.Data.Repository
{
    public class InMemoryUserRepository : IUserRepository
    {
        private List<User> users = new List<User>{
                new User {ID = 1, Name = "Shihab", Role = "Coordinator"},
                new User {ID =2, Name ="James", Role = "Admin"}
            };
        public User GetUserById(int id)
        {
            return users.Where(u => u.ID == id).FirstOrDefault();
        }

        public User GetUserByRole(string role)
        {
            return users.Where(u => u.Role == role).FirstOrDefault();
        }

        public List<User> ListUsers()
        {
            return users;
        }
    }
}