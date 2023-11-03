using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication4.Pages
{
    public class chungnhantotnghiepModel : PageModel
    {
        private readonly ILogger<chungnhantotnghiepModel> _logger;

        public chungnhantotnghiepModel(ILogger<chungnhantotnghiepModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}