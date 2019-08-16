using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataAccessLayer.Models;
using DataAccessLayer.Utilities;

namespace DataAccessLayer.Translators
{
    public static class UserTranslator
    {
        public static UsersModel TranslateAsUser(this SqlDataReader reader, bool isList = false)
        {
            if (!isList)
            {
                if (!reader.HasRows)
                    return null;
                reader.Read();
            }
            var item = new UsersModel();

            if (reader.IsColumnExists("Id"))
                item.Id = SqlHelper.GetNullableInt32(reader, "Id");

            if (reader.IsColumnExists("Name"))
                item.Name = SqlHelper.GetNullableString(reader, "Name");

            if (reader.IsColumnExists("Surname"))
                item.Surname = SqlHelper.GetNullableString(reader, "Surname");

            if (reader.IsColumnExists("Patronymic"))
                item.Patronymic = SqlHelper.GetNullableString(reader, "Patronymic");

            if (reader.IsColumnExists("Login"))
                item.Login = SqlHelper.GetNullableString(reader, "Login");

            if (reader.IsColumnExists("Password"))
                item.Password = SqlHelper.GetNullableString(reader, "Password");

            if (reader.IsColumnExists("Email"))
                item.Email = SqlHelper.GetNullableString(reader, "Email");

            if (reader.IsColumnExists("Role"))
                item.Role = SqlHelper.GetNullableString(reader, "Role");

            return item;
        }

        public static List<UsersModel> TranslateAsUsersList(this SqlDataReader reader)
        {
            var list = new List<UsersModel>();
            while (reader.Read())
            {
                list.Add(TranslateAsUser(reader, true));
            }
            return list;
        }
    }
}
