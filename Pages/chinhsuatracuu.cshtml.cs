using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication4.Pages
{
    public class chinhsuatracuuModel : PageModel
    {
        private readonly ILogger<chinhsuatracuuModel> _logger;

        public chinhsuatracuuModel(ILogger<chinhsuatracuuModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}