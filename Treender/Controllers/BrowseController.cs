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
        public IActionResult GetTreeSet()
        {
            var username = Request.Headers["name"];
            var preferences = (from user in _dbContext.Users where user.Username.Equals(username) select user.PreferencesFk).FirstOrDefault();

            if (preferences == null) return NoContent();

            var trees = (from tree in _dbContext.Trees
                where (tree.Height <= preferences.MaxHeight &&
                       tree.Height >= preferences.MinHeight &&
                       tree.Type == preferences.Type && tree.Specie == preferences.Specie)
                select tree).ToList();

            var jsonTrees = JsonConvert.SerializeObject(trees);

            return Ok(jsonTrees);
        }

        [HttpPost]
        [Route("/Like")]
        public async Task<IActionResult> Like()
        {
            var username = Request.Headers["name"];
            string body;
            using (var reader = new StreamReader(Request.Body))
                body = await reader.ReadToEndAsync();

            if (body == null) return NoContent();

            var user = (from u in _dbContext.Users where u.Username == username select u).FirstOrDefault();

            _dbContext.Likes.Add(new Like
            {
                Uid = new Guid(),
                UserId = user.Uid,
                TreeId = Guid.Parse(body)
            });

            _dbContext.SaveChanges();
            return Ok();
        }
    }
}
