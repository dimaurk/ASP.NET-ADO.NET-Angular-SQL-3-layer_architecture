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
    [Route("api/users")]
    public class UsersController : Controller
    {
        private readonly IOptions<ConnectSettingsModel> appSettings;

        public UsersController(IOptions<ConnectSettingsModel> app)
        {
            appSettings = app;
        }

        [HttpGet]
        [Route("AllUsers")]
        public IActionResult GetAllUsers()
        {

            var data = DbClientFactory<UsersDbClient>.Instance.GetAllUsers(appSettings.Value.ConnectionString);

            return Ok(data);
        }

        [HttpPost]
        [Route("SaveUser")]
        public IActionResult SaveUser([FromBody]UsersModel model)
        {
            var data = DbClientFactory<UsersDbClient>.Instance.SaveUser(model, appSettings.Value.ConnectionString);

            return Ok(data);
        }

        [HttpPost]
        [Route("DeleteUser")]
        public IActionResult DeleteUser([FromBody]UsersModel model)
        {
            var data = DbClientFactory<UsersDbClient>.Instance.DeleteUser(model.Id, appSettings.Value.ConnectionString);
           
            return Ok(data);
        }
    }
}