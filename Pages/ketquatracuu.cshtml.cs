using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication4.Pages
{
    public class ketquatracuuModel : PageModel
    {
        private readonly ILogger<ketquatracuuModel> _logger;

        public ketquatracuuModel(ILogger<ketquatracuuModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}