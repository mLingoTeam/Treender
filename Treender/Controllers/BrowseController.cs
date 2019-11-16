using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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
        public async Task<IActionResult> GetTreeSet()
        {
            List<Tree> trees;
            using (var reader = new StreamReader(Request.Body))
            {
                var username = await reader.ReadToEndAsync();
                var preferences = _dbContext.Users.FirstOrDefault(u => u.Username == username)?.PreferencesFk;
                if (preferences == null) return NotFound();

                trees = _dbContext.Trees.Where(tree => (tree.Height >= preferences.MinHeight &&
                                                        tree.Height <= preferences.MaxHeight &&
                                                        tree.Type == preferences.Type && tree.Specie == preferences.Specie)).ToList();
            }

            return Ok(trees);
        }
    }
}
