using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Treender.Data;
using Treender.Data.DbModels;

namespace Treender.Controllers
{
    public class HomeController : Controller
    {
        private ILogger<HomeController> _logger;
        private AppDatabaseContext _dbContext;

        public HomeController(ILogger<HomeController> logger, AppDatabaseContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpPost]
        [Route("/Login")]
        public async Task LoginAsync()
        {
            using (var reader = new StreamReader(Request.Body))
            {
                var body = await reader.ReadToEndAsync();

                //create default user prefernces
                Preference pref = new Preference
                {
                    Uid = new Guid(),
                    MaxHeight = 0,
                    MinHeight = 0,
                    Specie = 1,
                    Type = 1
                };

                _dbContext.Preferences.Add(pref);
                
                //create new user with default preferences
                _dbContext.Users.Add(new User
                {
                    Username = body,
                    Uid = new Guid(),
                    Preferences = pref.Uid
                });
                _dbContext.SaveChanges();
            }
        }
    }
}
