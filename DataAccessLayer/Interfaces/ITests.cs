using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Models;

namespace DataAccessLayer.Interfaces
{
    interface ITests
    {
        List<TestsModel> GetAllTests(string connString);
    }
}
