using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using MultitenantCoreApp.Models;
using System.Diagnostics;

namespace MultitenantCoreApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITenantContext _tenantContext;

        public HomeController(ILogger<HomeController> logger, ITenantContext tenantContext)
        {
            _logger = logger;
            _tenantContext = tenantContext;
        }

        public IActionResult Index()
        {
            var tenantName = _tenantContext.CurrentTenant.Name;
            return Content($"Hello World: '{tenantName}'");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}