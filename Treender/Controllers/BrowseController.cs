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
            var rng = new Random();
            var trees = new List<Tree>();
            var tct = rng.Next(20, 30);
            var treesdb = _dbContext.Trees.ToList();
            for (int i = 0; i < tct; i++) trees.Add(treesdb[rng.Next(treesdb.Count)]);
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
