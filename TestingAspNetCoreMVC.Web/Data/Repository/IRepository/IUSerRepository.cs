using System.Collections.Generic;
using TestingAspNetCoreMVC.Web.Models;

namespace TestingAspNetCoreMVC.Web.Data.Repository.IRepository
{
    public interface IUserRepository
    {
        List<User> ListUsers();

        User GetUserById(int id);
        User GetUserByRole(string role);
    }
}