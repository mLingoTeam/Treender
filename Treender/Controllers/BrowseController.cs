using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
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
        public async Task<IActionResult> GetTreeSet()
        {
            var username = Request.Headers["name"];
            var preferences = (from user in _dbContext.Users where user.Username.Equals(username) select user.PreferencesFk).FirstOrDefault();

            var trees = (from tree in _dbContext.Trees
                where (tree.Height <= preferences.MaxHeight &&
                       tree.Height >= preferences.MinHeight &&
                       tree.Type == preferences.Type && tree.Specie == preferences.Specie)
                select tree).ToList();

            var jsonTrees = JsonConvert.SerializeObject(trees);

            return StatusCode(200, jsonTrees);
        }

        [HttpPut]
        [Route("/Like")]
        public async Task<IActionResult> Like()
        {
            var username = Request.Headers["name"];
            string body;
            using (var reader = new StreamReader(Request.Body))
                body = await reader.ReadToEndAsync();

            if (body == null) return NoContent();

            

            return Ok();
        }
    }
}
