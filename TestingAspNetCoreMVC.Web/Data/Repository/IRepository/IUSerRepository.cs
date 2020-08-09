using System.Collections.Generic;
using TestingAspNetCoreMVC.Web.Models;

namespace TestingAspNetCoreMVC.Web.Data.Repository.IRepository
{
    public interface IUSerRepository
    {
        List<User> ListUsers();
    }
}