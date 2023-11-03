using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication4.Pages
{
    public class trangthaicntnModel : PageModel
    {
        private readonly ILogger<trangthaicntnModel> _logger;

        public trangthaicntnModel(ILogger<trangthaicntnModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}