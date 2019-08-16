using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataAccessLayer.Models;
using DataAccessLayer.Utilities;

namespace DataAccessLayer.Translators
{
    public static class CoursesTranslator
    {
        public static CoursesModel TranslateAsCourses(this SqlDataReader reader, bool isList = false)
        {
            if (!isList)
            {
                if (!reader.HasRows)
                    return null;
                reader.Read();
            }
            var item = new CoursesModel();

            if (reader.IsColumnExists("Id"))
                item.Id = SqlHelper.GetNullableInt32(reader, "Id");

            if (reader.IsColumnExists("Title"))
                item.Title = SqlHelper.GetNullableString(reader, "Title");

            if (reader.IsColumnExists("Discription"))
                item.Discription = SqlHelper.GetNullableString(reader, "Discription");

            if (reader.IsColumnExists("Section"))
                item.Section = SqlHelper.GetNullableString(reader, "Section");

            return item;
        }

        public static List<CoursesModel> TranslateAsCoursesList(this SqlDataReader reader)
        {
            var list = new List<CoursesModel>();
            while (reader.Read())
            {
                list.Add(TranslateAsCourses(reader, true));
            }
            return list;
        }
    }
}
