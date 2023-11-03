using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication4.Pages
{
    public class qltranghthaihoanthiModel : PageModel
    {
        private readonly ILogger<qltranghthaihoanthiModel> _logger;

        public qltranghthaihoanthiModel(ILogger<qltranghthaihoanthiModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}