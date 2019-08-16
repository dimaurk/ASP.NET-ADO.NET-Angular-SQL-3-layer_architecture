using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Models;

namespace DataAccessLayer.Interfaces
{
    interface IAnswers
    {
        List<AnswersModel> GetAllAnswers(string connString);
    }
}
