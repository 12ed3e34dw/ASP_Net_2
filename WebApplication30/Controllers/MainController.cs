using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication30.Data;

namespace WebApplication30
{
    public class MainController : Controller
    {
  
     /// База данных

     private readonly WebApplication30Context _context;

        public MainController(WebApplication30Context context)
        {
            _context = context;
        }
        //_____________________________________________________________________________________
        //View
        public IActionResult Category()
        {
            return View();
        }
      
        public IActionResult Delete()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
        //_____________________________________________________________________________________
        //Search
        [HttpGet("search")]
        public async Task<IActionResult> Search(string query)
        {
            if (string.IsNullOrEmpty(query))
            {
                return BadRequest("Search query cannot be empty.");
            }

            var results = await _context.Shops
                .Where(p => p.Name.Contains(query) || p.Description.Contains(query))
                .ToListAsync();

            return Ok(results);
        }
    }
}
