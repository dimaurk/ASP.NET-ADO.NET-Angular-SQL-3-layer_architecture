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
    public class CoursesDbClient : ICourses
    {
        public List<CoursesModel> GetAllCourses(string connString)
        {
            return SqlHelper.ExtecuteProcedureReturnData<List<CoursesModel>>(connString,
                "GetCourses", r => r.TranslateAsCoursesList());
        }
    }
}
