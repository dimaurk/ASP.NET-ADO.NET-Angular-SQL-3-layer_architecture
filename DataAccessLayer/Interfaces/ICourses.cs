using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Models;

namespace DataAccessLayer.Interfaces
{
    interface ICourses
    {
        List<CoursesModel> GetAllCourses(string connString);
    }
}
