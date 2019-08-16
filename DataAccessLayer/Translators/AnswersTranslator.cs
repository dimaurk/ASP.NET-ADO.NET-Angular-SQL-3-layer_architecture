using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataAccessLayer.Models;
using DataAccessLayer.Utilities;

namespace DataAccessLayer.Translators
{
    public static class AnswersTranslator
    {
        public static AnswersModel TranslateAsAnswers(this SqlDataReader reader, bool isList = false)
        {
            if (!isList)
            {
                if (!reader.HasRows)
                    return null;
                reader.Read();
            }
            var item = new AnswersModel();

            if (reader.IsColumnExists("Id"))
                item.Id = SqlHelper.GetNullableInt32(reader, "Id");

            if (reader.IsColumnExists("Answer"))
                item.Answer = SqlHelper.GetNullableString(reader, "Answer");

            if (reader.IsColumnExists("QuestionId"))
                item.QuestionId = SqlHelper.GetNullableInt32(reader, "QuestionId");

            return item;
        }

        public static List<AnswersModel> TranslateAsAnswersList(this SqlDataReader reader)
        {
            var list = new List<AnswersModel>();
            while (reader.Read())
            {
                list.Add(TranslateAsAnswers(reader, true));
            }
            return list;
        }
    }
}
