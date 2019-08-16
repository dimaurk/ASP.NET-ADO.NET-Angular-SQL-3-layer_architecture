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
    public class AnswersDbClient : IAnswers
    {
        public List<AnswersModel> GetAllAnswers(string connString)
        {
            return SqlHelper.ExtecuteProcedureReturnData<List<AnswersModel>>(connString,
                "GetAnswers", r => r.TranslateAsAnswersList());
        }
    }
}
