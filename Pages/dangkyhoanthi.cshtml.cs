using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication4.Pages
{
    public class dangkyhoanthiModel : PageModel
    {
        private readonly ILogger<dangkyhoanthiModel> _logger;

        public dangkyhoanthiModel(ILogger<dangkyhoanthiModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}