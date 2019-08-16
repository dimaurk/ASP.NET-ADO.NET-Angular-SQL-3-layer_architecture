using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataAccessLayer.Models;
using DataAccessLayer.Utilities;

namespace DataAccessLayer.Translators
{
    public static class SertificatesTranslator
    {
        public static SertificatesModel TranslateAsSertificates(this SqlDataReader reader, bool isList = false)
        {
            if (!isList)
            {
                if (!reader.HasRows)
                    return null;
                reader.Read();
            }
            var item = new SertificatesModel();

            if (reader.IsColumnExists("Id"))
                item.Id = SqlHelper.GetNullableInt32(reader, "Id");

            if (reader.IsColumnExists("Title"))
                item.Title = SqlHelper.GetNullableString(reader, "Title");

            if (reader.IsColumnExists("Discription"))
                item.Discription = SqlHelper.GetNullableString(reader, "Discription");

            if (reader.IsColumnExists("CurseId"))
                item.CurseId = SqlHelper.GetNullableInt32(reader, "CurseId");

            if (reader.IsColumnExists("UserId"))
                item.UserId = SqlHelper.GetNullableInt32(reader, "UserId");

            return item;
        }

        public static List<SertificatesModel> TranslateAsSertificatesList(this SqlDataReader reader)
        {
            var list = new List<SertificatesModel>();
            while (reader.Read())
            {
                list.Add(TranslateAsSertificates(reader, true));
            }
            return list;
        }
    }
}
