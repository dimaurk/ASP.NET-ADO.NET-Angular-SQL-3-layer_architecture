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
    public class LessonsDbClient : ILessons
    {
        public List<LessonsModel> GetAllLessons(string connString)
        {
            return SqlHelper.ExtecuteProcedureReturnData<List<LessonsModel>>(connString,
                "GetLessons", r => r.TranslateAsLessonsList());
        }
    }
}
