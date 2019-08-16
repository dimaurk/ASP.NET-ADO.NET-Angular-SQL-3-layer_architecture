using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Models;

namespace DataAccessLayer.Interfaces
{
    interface ILessons
    {
        List<LessonsModel> GetAllLessons(string connString);
    }
}
