using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Treender.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        public bool Login(ILogger<HomeController> logger, string username)
        {
            logger.LogInformation(username);
            return false;
        }
    }
}
