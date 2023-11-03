using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication4.Pages
{
    public class qltranghthaidiemthiModel : PageModel
    {
        private readonly ILogger<qltranghthaidiemthiModel> _logger;

        public qltranghthaidiemthiModel(ILogger<qltranghthaidiemthiModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}