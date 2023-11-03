using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication4.Pages
{
    public class qldsyeucauModel : PageModel
    {
        private readonly ILogger<qldsyeucauModel> _logger;

        public qldsyeucauModel(ILogger<qldsyeucauModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}