using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataAccessLayer.Models;
using DataAccessLayer.Utilities;

namespace DataAccessLayer.Translators
{
    public static class LessonsTranslator
    {
        public static LessonsModel TranslateAsLessons(this SqlDataReader reader, bool isList = false)
        {
            if (!isList)
            {
                if (!reader.HasRows)
                    return null;
                reader.Read();
            }
            var item = new LessonsModel();

            if (reader.IsColumnExists("Id"))
                item.Id = SqlHelper.GetNullableInt32(reader, "Id");

            if (reader.IsColumnExists("Title"))
                item.Title = SqlHelper.GetNullableString(reader, "Title");

            if (reader.IsColumnExists("Discription"))
                item.Discription = SqlHelper.GetNullableString(reader, "Discription");

            if (reader.IsColumnExists("Chapter"))
                item.Chapter = SqlHelper.GetNullableString(reader, "Chapter");

            if (reader.IsColumnExists("Text"))
                item.Text = SqlHelper.GetNullableString(reader, "Text");

            if (reader.IsColumnExists("CurseId"))
                item.CurseId = SqlHelper.GetNullableInt32(reader, "CurseId");

            return item;
        }

        public static List<LessonsModel> TranslateAsLessonsList(this SqlDataReader reader)
        {
            var list = new List<LessonsModel>();
            while (reader.Read())
            {
                list.Add(TranslateAsLessons(reader, true));
            }
            return list;
        }
    }
}
