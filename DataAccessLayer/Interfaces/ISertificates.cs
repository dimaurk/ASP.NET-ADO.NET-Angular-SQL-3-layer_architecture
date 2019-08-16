using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Models;

namespace DataAccessLayer.Interfaces
{
    interface ISertificates
    {
        List<SertificatesModel> GetAllSertificates(string connString);
    }
}
