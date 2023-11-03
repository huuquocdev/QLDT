using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication4.Pages
{
    public class trangthaidiemthiModel : PageModel
    {
        private readonly ILogger<trangthaidiemthiModel> _logger;

        public trangthaidiemthiModel(ILogger<trangthaidiemthiModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}