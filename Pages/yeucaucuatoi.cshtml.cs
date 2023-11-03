using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication4.Pages
{
    public class yeucaucuatoiModel : PageModel
    {
        private readonly ILogger<yeucaucuatoiModel> _logger;

        public yeucaucuatoiModel(ILogger<yeucaucuatoiModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}