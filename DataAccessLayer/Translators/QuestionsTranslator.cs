using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataAccessLayer.Models;
using DataAccessLayer.Utilities;

namespace DataAccessLayer.Translators
{
    public static class QuestionsTranslator
    {
        public static QuestionsModel TranslateAsQuestions(this SqlDataReader reader, bool isList = false)
        {
            if (!isList)
            {
                if (!reader.HasRows)
                    return null;
                reader.Read();
            }
            var item = new QuestionsModel();

            if (reader.IsColumnExists("Id"))
                item.Id = SqlHelper.GetNullableInt32(reader, "Id");

            if (reader.IsColumnExists("Question"))
                item.Question = SqlHelper.GetNullableString(reader, "Question");

            if (reader.IsColumnExists("TestId"))
                item.TestId = SqlHelper.GetNullableInt32(reader, "TestId");

            return item;
        }

        public static List<QuestionsModel> TranslateAsQuestionsList(this SqlDataReader reader)
        {
            var list = new List<QuestionsModel>();
            while (reader.Read())
            {
                list.Add(TranslateAsQuestions(reader, true));
            }
            return list;
        }
    }
}
