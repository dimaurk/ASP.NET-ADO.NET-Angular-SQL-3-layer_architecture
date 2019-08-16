using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.Models;
using DataAccessLayer.Translators;
using DataAccessLayer.Utilities;
using DataAccessLayer.Interfaces;

namespace DataAccessLayer.Repository
{
    public class QuestionsDbClient : IQuestions
    {
        public List<QuestionsModel> GetAllQuestions(string connString)
        {
            return SqlHelper.ExtecuteProcedureReturnData<List<QuestionsModel>>(connString,
                "GetQuestions", r => r.TranslateAsQuestionsList());
        }
    }
}
