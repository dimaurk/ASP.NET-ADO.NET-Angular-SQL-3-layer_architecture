using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataAccessLayer.Models;
using DataAccessLayer.Utilities;

namespace DataAccessLayer.Translators
{
    public static class TestsTranslator
    {
        public static TestsModel TranslateAsTests(this SqlDataReader reader, bool isList = false)
        {
            if (!isList)
            {
                if (!reader.HasRows)
                    return null;
                reader.Read();
            }
            var item = new TestsModel();

            if (reader.IsColumnExists("Id"))
                item.Id = SqlHelper.GetNullableInt32(reader, "Id");

            if (reader.IsColumnExists("Title"))
                item.Title = SqlHelper.GetNullableString(reader, "Title");

            if (reader.IsColumnExists("Discription"))
                item.Discription = SqlHelper.GetNullableString(reader, "Discription");

            if (reader.IsColumnExists("CurseId"))
                item.CurseId = SqlHelper.GetNullableInt32(reader, "CurseId");

            return item;
        }

        public static List<TestsModel> TranslateAsTestsList(this SqlDataReader reader)
        {
            var list = new List<TestsModel>();
            while (reader.Read())
            {
                list.Add(TranslateAsTests(reader, true));
            }
            return list;
        }
    }
}
