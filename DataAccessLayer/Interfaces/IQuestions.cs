using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Models;

namespace DataAccessLayer.Interfaces
{
    interface IQuestions
    {
        List<QuestionsModel> GetAllQuestions(string connString);
    }
}
