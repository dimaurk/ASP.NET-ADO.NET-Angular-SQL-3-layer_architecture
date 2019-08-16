using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.Models;
using DataAccessLayer.Translators;
using DataAccessLayer.Utilities;
using System.Data.SqlClient;
using System.Data;
using DataAccessLayer.Interfaces;

namespace DataAccessLayer.Repository
{
    public class UsersDbClient : IUsers
    {
        public List<UsersModel> GetAllUsers(string connString)
        {
            return SqlHelper.ExtecuteProcedureReturnData<List<UsersModel>>(connString,
                "GetUsers", r => r.TranslateAsUsersList());
        }

        
    }
}
