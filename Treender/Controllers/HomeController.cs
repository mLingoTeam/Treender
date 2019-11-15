using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
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
        }
    }
}
