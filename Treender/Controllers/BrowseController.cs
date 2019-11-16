using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Microsoft.Extensions.Logging;
using Treender.Data;
using Treender.Data.DbModels;

namespace Treender.Controllers
{
    public class BrowseController : Controller
    {
        private ILogger _logger;
        private AppDatabaseContext _dbContext;

        public BrowseController(ILogger<BrowseController> logger, AppDatabaseContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpGet]
        [Route("/GetUserTrees")]
        public IActionResult GetTreeSet()
        {
            var username = Request.Headers["name"];
            var preferences = from user in _dbContext.Users where user.Username.Equals(username) select user.PreferencesFk;
            

            return Ok(Json(""));
        }

        [HttpPost]
        [Route("/Like")]
        public async Task<IActionResult> Like()
        {


            return Ok();
        }
    }
}
