using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication4.Pages
{
    public class qltranghthaicntnModel : PageModel
    {
        private readonly ILogger<qltranghthaicntnModel> _logger;

        public qltranghthaicntnModel(ILogger<qltranghthaicntnModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}