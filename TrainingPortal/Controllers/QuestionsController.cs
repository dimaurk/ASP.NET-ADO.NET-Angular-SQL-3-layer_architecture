using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using DataAccessLayer.Models;
using DataAccessLayer.ConnectionSettings;
using DataAccessLayer.Repository;
using DataAccessLayer.Utilities;
using DataAccessLayer.Translators;

namespace TrainingPortal.Controllers
{
    [Produces("application/json")]
    [Route("api/questions")]
    public class QuestionsController : Controller
    {
        private readonly IOptions<ConnectSettingsModel> appSettings;

        public QuestionsController(IOptions<ConnectSettingsModel> app)
        {
            appSettings = app;
        }

        [HttpGet]
        public IActionResult GetQuestions()
        {

            var data = DbClientFactory<QuestionsDbClient>.Instance.GetAllQuestions(appSettings.Value.ConnectionString);

            return Ok(data);
        }
    }
}