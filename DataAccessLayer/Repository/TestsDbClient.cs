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
    public class TestsDbClient : ITests
    {
        public List<TestsModel> GetAllTests(string connString)
        {
            return SqlHelper.ExtecuteProcedureReturnData<List<TestsModel>>(connString,
                "GetTests", r => r.TranslateAsTestsList());
        }
    }
}
