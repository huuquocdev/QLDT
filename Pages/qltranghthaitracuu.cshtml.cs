using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication4.Pages
{
    public class qltranghthaitracuuModel : PageModel
    {
        private readonly ILogger<qltranghthaitracuuModel> _logger;

        public qltranghthaitracuuModel(ILogger<qltranghthaitracuuModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}