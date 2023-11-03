using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication4.Pages
{
    public class trangthaitracuuModel : PageModel
    {
        private readonly ILogger<trangthaitracuuModel> _logger;

        public trangthaitracuuModel(ILogger<trangthaitracuuModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}