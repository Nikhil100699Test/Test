using Microsoft.AspNetCore.Mvc;
using TestApp.Data;
using TestApp.Models;

namespace TestApp.Controllers
{
    public class IntergerSumController : Controller
    {
        public readonly ApplicationDbContext _context;
        public IntergerSumController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(int firstnum, int secondnum)
        {
            IntegerSum integerSum = new IntegerSum();
            integerSum.FirstNumber = firstnum;
            integerSum.SecondNumber = secondnum;
            integerSum.ResultedNumber = integerSum.FirstNumber + integerSum.SecondNumber;
            _context.IntegerSums.Add(integerSum);
            _context.SaveChanges();
            return Ok(integerSum.ResultedNumber);
        }

        public IActionResult Test(int firstnum, int secondnum)
        {
            return NotFound();
        }

    }
}
