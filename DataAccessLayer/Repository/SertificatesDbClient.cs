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
    public class SertificatesDbClient : ISertificates
    {
        public List<SertificatesModel> GetAllSertificates(string connString)
        {
            return SqlHelper.ExtecuteProcedureReturnData<List<SertificatesModel>>(connString,
                "GetSertificates", r => r.TranslateAsSertificatesList());
        }
    }
}
