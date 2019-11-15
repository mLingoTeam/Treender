using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Logging;
using Treender.Data;

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
        public async Task<bool> LoginAsync()
        {
            using (var reader = new StreamReader(Request.Body))
            {
                var body = await reader.ReadToEndAsync();
                _logger.LogInformation(body);
            }

            return false;
        }
    }
}
