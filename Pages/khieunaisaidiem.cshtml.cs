using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication4.Pages
{
    public class khieunaisaidiemModel : PageModel
    {
        private readonly ILogger<khieunaisaidiemModel> _logger;

        public khieunaisaidiemModel(ILogger<khieunaisaidiemModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}