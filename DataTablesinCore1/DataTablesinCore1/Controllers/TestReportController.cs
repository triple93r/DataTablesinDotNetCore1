using DataTablesinCore1.Data;
using DataTablesinCore1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DataTablesinCore1.Controllers
{
    public class TestReportController : Controller
    {
        private readonly ILogger<TestReportController> _logger;
        private readonly ApplicationDbContext _context;

        public TestReportController(ILogger<TestReportController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult Index()
        {
            var x = _context.TblBananaStock.Where(x=>x.Details.Contains("deposit")).ToList();
            return View(x);
        }
    }
}
