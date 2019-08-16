using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Models;

namespace DataAccessLayer.Interfaces
{
    interface IUsers
    {
        List<UsersModel> GetAllUsers(string connString);
    }
}
